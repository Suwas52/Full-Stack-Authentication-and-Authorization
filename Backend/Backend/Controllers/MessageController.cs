using Backend.Core.Constants;
using Backend.Core.DTOs.Message;
using Backend.Core.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpPost]
        [Route("Create")]
        [Authorize]

        public async Task<IActionResult> CreateNewMessage([FromBody] CreateMessageDto createMessageDto)
        {
            var result = await _messageService.CreateNewMessageAsync(User, createMessageDto);

            if (result.IsSucceed)
            {
                return Ok(result.Message);
            }

            return StatusCode(result.StatusCode, result.Message);
        }

        [HttpGet]
        [Route("My-Message")]
        [Authorize]

        public async Task<ActionResult<IEnumerable<GetMessageDto>>> GetMyMessage()
        {
            var messages = _messageService.GetMyMessagesAsync(User);
            return Ok(messages);
        }

        [HttpGet]
        [Authorize(Roles = StaticUserRoles.OwnerAdmin)]

        public async Task<ActionResult<IEnumerable<GetMessageDto>>> GetMessage()
        {
            var messages = await _messageService.GetMessagesAsync();
            return Ok(messages);    
        }

    }
}
