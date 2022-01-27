using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ATM.Controllers
{
    [ApiController]
    [Route("")]
    public class AtmController : ControllerBase
    {

        private readonly IAtmModel _atmModel;

        public AtmController(IAtmModel atmModel)
        {
            _atmModel = atmModel;
        }

        [HttpGet("ClientById")]
        public IActionResult Client(int Id)
        {
            try
            {
                Client client = _atmModel.Client(Id);
                return Ok(client);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet("ClientByUsername")]
        public IActionResult Client(string Username)
        {
            try
            {
                Client client = _atmModel.Client(Username);
                return Ok(client);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost("CreateClientAsync")]
        public async Task<IActionResult> CreateClient(Client client)
        {
            try
            {
                var result = await _atmModel.CreateClientAsync(client);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("TransactionHistoryAsync")]
        public async Task<IActionResult> TransactionHistory(int IdAccount)
        {
            var result = await _atmModel.TransactionHistoryAsync(IdAccount);

            return Ok(result);
        }

        [HttpPost("InsertMoneyAsync")]
        public async Task<IActionResult> InsertMoney(int IdAccount, decimal amount)
        {
            try
            {
                var result = await _atmModel.InsertMoneyAsync(IdAccount, amount);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("WithdrawMoneyAsync")]
        public async Task<IActionResult> WithdrawMoneyAsync(int IdAccount, decimal amount)
        {
            try
            {
                var result = await _atmModel.WithdrawMoney(IdAccount, amount);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        [HttpPost("SendMoneyAsync")]
        public async Task<IActionResult> SendMoneyAsync(int IdAccount, int IdRecipientAccount, decimal amount, int? variableNumber, string note, string noteForRecipient)
        {
            try
            {
                var result = await _atmModel.SendMoney(IdAccount, IdRecipientAccount, amount, variableNumber, note, noteForRecipient);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("Authenticate")]
        public bool Authenticate(string username, string pinCode)
        {
            var result = _atmModel.Authenticate(username, pinCode);

            return result;
        }

        [HttpGet("MonthlyInterest")]
        public double MonthlyInterest()
        {
            var result = _atmModel.MonthlyInterest();

            return result;
        }

    }
}