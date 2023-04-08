using Cross.Logging;
using Crud.Models;
using customersApi.Models;
using customersApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace customersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class customersController : ControllerBase
    {

        private readonly IcustomersRepository _customersRepository;
        private readonly ILoggingManager _loggingManager;

        public customersController(IcustomersRepository customerRepository, ILoggingManager loggingManager)
        {
            _customersRepository = customerRepository;
            _loggingManager = loggingManager;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllcustomers()
        {
            _loggingManager.LogInformation("se recibe la petición metodo GET  /API/customers");
            var timerSendMessageToSource = Stopwatch.StartNew();
            try
            {
                List<customers> cus = (List<customers>)await _customersRepository.GetAllCustomers();
                timerSendMessageToSource.Stop();
                _loggingManager.LogInformation($"tiempo de respuesta in {timerSendMessageToSource.ElapsedMilliseconds}ms");
                _loggingManager.LogInformation($"Object response {(JsonConvert.SerializeObject(cus))}");
                if (cus.Count == 0)
                {
                    _loggingManager.LogInformation($"Object resultado {"No se encontraron registros"}");
                    _loggingManager.LogInformation($"httpstatus: resultado {StatusCodes.Status200OK}");
                    return this.Ok(ResultModel.Ok(StatusCodes.Status200OK.ToString(), cus, "No se encontraron registros", null));
                }
                _loggingManager.LogInformation($"httpstatus: {StatusCodes.Status200OK}");
                _loggingManager.LogInformation($"Object resultado {"Consulta Exitosa"}");
                return this.Ok(ResultModel.Ok(StatusCodes.Status200OK.ToString(), cus, "Consulta Existosa", null));
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                _loggingManager.LogError($"tiempo de respuesta in {timerSendMessageToSource.ElapsedMilliseconds}ms");
                _loggingManager.LogError($"HttpStatus: {StatusCodes.Status500InternalServerError}");
                _loggingManager.LogError($"Se ha presentado el siguiente error: {e.Message}");
                return this.Ok(ResultModel.Error(e.Message, StatusCodes.Status500InternalServerError.ToString()));
            }
            catch (Exception e)
            {
                _loggingManager.LogError($"tiempo de respuesta in {timerSendMessageToSource.ElapsedMilliseconds}ms");
                _loggingManager.LogError($"Se ha presentado el siguiente error: {e.Message}");
                _loggingManager.LogError($"HttpStatus: {StatusCodes.Status500InternalServerError}");
                return this.Ok(ResultModel.Error(e.Message, StatusCodes.Status500InternalServerError.ToString()));
            }


        }



        [HttpPost]
        public async Task<IActionResult> Insertcustomers([FromBody] object client)
        {


            dynamic jsonObj = JsonConvert.DeserializeObject(client.ToString());

            _loggingManager.LogInformation("se recibe la petición metodo POST /API/customers");

            var fecha = jsonObj["fecha"].ToString();
            var nmbre = jsonObj["nombre"].ToString();
            var apellido = jsonObj["apellido"].ToString();
            var email = jsonObj["email"].ToString();
            _loggingManager.LogInformation($"Object request {(JsonConvert.SerializeObject(client))}");
            var timerSendMessageToSource = Stopwatch.StartNew();
            try
            {

                if (!validarcorreo(email))
                {
                    timerSendMessageToSource.Stop();
                    _loggingManager.LogError($"tiempo de respuesta in {timerSendMessageToSource.ElapsedMilliseconds}ms");
                    _loggingManager.LogError($"httpstatus: resultado {StatusCodes.Status400BadRequest}");
                    _loggingManager.LogError($"Se ha presentado el siguiente error: {"Formato de correo invalido"}");
                    return this.Ok(ResultModel.Error("Formato de correo invalido", StatusCodes.Status400BadRequest.ToString()));
                }

                if (!validarfecha(fecha))
                {
                    timerSendMessageToSource.Stop();
                    _loggingManager.LogError($"tiempo de respuesta in {timerSendMessageToSource.ElapsedMilliseconds}ms");
                    _loggingManager.LogError($"httpstatus: resultado {StatusCodes.Status400BadRequest}");
                    _loggingManager.LogError($"Se ha presentado el siguiente error: {"Formato de fecha invalido"}");
                    return this.Ok(ResultModel.Error("Formato de fecha invalido", StatusCodes.Status400BadRequest.ToString()));
                }

                customers clien = new customers();
                clien.nombre = nmbre;
                clien.apellido = apellido;
                clien.email = email;
                clien.fecha = DateTime.Parse(fecha);


                bool reusltado = await _customersRepository.InsertCustomer(clien);
                timerSendMessageToSource.Stop();
                _loggingManager.LogInformation($"tiempo de respuesta in {timerSendMessageToSource.ElapsedMilliseconds}ms");
                if (reusltado)
                {
                    _loggingManager.LogInformation($"httpstatus: resultado {StatusCodes.Status200OK}");
                    _loggingManager.LogInformation($"Object resultado {"Registro creado"}");
                    return this.Ok(ResultModel.Ok(StatusCodes.Status200OK.ToString(), null, "Registro creado", null));
                }
                _loggingManager.LogInformation($"httpstatus: resultado {StatusCodes.Status200OK}");
                _loggingManager.LogInformation($"Object resultado {"Error al ingresar el cliente"}");
                return this.Ok(ResultModel.Ok(StatusCodes.Status200OK.ToString(), null, "Error al ingresar el cliente", null));
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                _loggingManager.LogError($"tiempo de respuesta in {timerSendMessageToSource.ElapsedMilliseconds}ms");
                _loggingManager.LogError($"HttpStatus: {StatusCodes.Status500InternalServerError}");
                _loggingManager.LogError($"Se ha presentado el siguiente error: {e.Message}");
                return this.Ok(ResultModel.Error(e.Message, StatusCodes.Status500InternalServerError.ToString()));
            }
            catch (Exception e)
            {
                _loggingManager.LogError($"tiempo de respuesta in {timerSendMessageToSource.ElapsedMilliseconds}ms");
                _loggingManager.LogError($"HttpStatus: {StatusCodes.Status500InternalServerError}");
                _loggingManager.LogError($"Se ha presentado el siguiente error: {e.Message}");
                return this.Ok(ResultModel.Error(e.Message, StatusCodes.Status500InternalServerError.ToString()));
            }



        }

        private bool validarfecha(dynamic fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool validarcorreo(dynamic email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
