using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ATM.Controllers {
   [ApiController]
   [Route("")]
   public class AtmController : ControllerBase {

      private readonly IAtmModel _atmModel;

      public AtmController(IAtmModel atmModel) {
         _atmModel = atmModel;
      }

      [HttpGet("ClientById")]
      public IActionResult Client(int Id) {
         Client client;
         try {
            client = _atmModel.Client(Id);
         }
         catch (Exception) {
            return NotFound();
         }

         return Ok(client);
      }

      [HttpGet("ClientByUsername")]
      public IActionResult Client(string Username) {
         Client client;
         try {
            client = _atmModel.Client(Username);
         }
         catch (Exception) {
            return NotFound();
         }

         return Ok(client);
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

      /// <summary>
      /// Status 400 = Klient chce vložit 0 a méně peněz. Amount nesmí být <= 0.
      /// </summary>
      /// <param name="IdAccount"></param>
      /// <param name="amount"></param>
      /// <returns></returns>
      [HttpPost("InsertMoney")]
      public async Task<IActionResult> InsertMoney(int IdAccount, decimal amount) {
         if (amount > 0) {
            var result = await _atmModel.InsertMoney(IdAccount, amount);

            return Ok(result);
         }
         return BadRequest();
      }

      [HttpPost("WithdrawMoney")]
      public async Task<IActionResult> WithdrawMoney(int IdAccount, decimal amount) {
         //tohle obalit try casths
         if (amount > 0) {
            var result = await _atmModel.WithdrawMoney(IdAccount, amount);

            return Ok(result);
         }
         return BadRequest();
      }

      /// <summary>
      /// 204 = Nedostatek peněz, nebo neexistující Id příjemce.
      /// Status 400 = Klient chce poslat 0 a méně peněz. Amount nesmí být <= 0.
      /// </summary>
      /// <param name="IdAccount">Id účtu z kterého jsou peníze odesílaný.</param>
      /// <param name="IdRecipientAccount">Id účtu na který jsou peníze zasílaný.</param>
      /// <param name="amount">Částka.</param>
      /// <param name="variableNumber">Variabilní číslo.</param>
      /// <param name="note">Poznámka, kterou vidí jenom odesílatel.</param>
      /// <param name="noteForRecipient">Poznámka pro příjemce, zobrazí se příjemci ve sloupci Note.</param>
      /// <returns></returns>
      [HttpPost("SendMoney")]
      public async Task<IActionResult> SendMoney(int IdAccount, int IdRecipientAccount, decimal amount, int? variableNumber, string note, string noteForRecipient) {
         if (amount <= 0)
            return BadRequest();
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