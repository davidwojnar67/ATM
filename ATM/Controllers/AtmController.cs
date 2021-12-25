using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM.Controllers {
   [ApiController]
   [Route("")]
   public class AtmController : ControllerBase {

      private readonly IAtmModel _atmModel;

      public AtmController(IAtmModel atmModel) {
         _atmModel = atmModel;
      }

      [HttpGet("Client")]
      public async Task<IActionResult> Client(int Id) {
         var result = await _atmModel.Client(Id);

         return Ok(result);
      }

      [HttpPost("CreateClient")]
      public async Task<IActionResult> CreateClient(Client client) {
         var result = await _atmModel.CreateClient(client);

         return Ok(result);
      }

      [HttpGet("TransactionHistory")]
      public async Task<IActionResult> TransactionHistory(int IdAccount) {
         var result = await _atmModel.TransactionHistory(IdAccount);

         return Ok(result);
      }

      [HttpPatch("InsertMoney")]
      public async Task<IActionResult> InsertMoney(int IdAccount, decimal amount) {
         var result = await _atmModel.InsertMoney(IdAccount, amount);

         return Ok(result);
      }

      [HttpPatch("WithdrawMoney")]
      public async Task<IActionResult> WithdrawMoney(int IdAccount, decimal amount) {
         var result = await _atmModel.WithdrawMoney(IdAccount, amount);

         return Ok(result);
      }

      [HttpPatch("SendMoney")]
      public async Task<IActionResult> SendMoney(int IdAccount, int IdRecipientAccount, decimal amount, int? variableNumber, string note, string noteForRecipient) {
         var result = await _atmModel.SendMoney(IdAccount, IdRecipientAccount, amount, variableNumber, note, noteForRecipient);

         return Ok(result);
      }

      [HttpGet("Authenticate")]
      public bool Authenticate(string username, string pinCode) {
         var result = _atmModel.Authenticate(username, pinCode);

         return result;
      }

   }
}