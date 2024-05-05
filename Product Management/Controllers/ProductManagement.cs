using Microsoft.AspNetCore.Mvc;
using Product.Management.Application.Interfaces;
using Product.Management.Application.ViewModel;
using Product.Management.Domain.Entity;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Product.Management.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductManagement : ControllerBase
    {

        private readonly ILogger<ProductManagement> _logger;
        private readonly IFinancialProductApp _financialProductApp;

        public ProductManagement(ILogger<ProductManagement> logger, IFinancialProductApp financialProductApp)
        {
            _logger = logger;
            _financialProductApp = financialProductApp;
        }

        [HttpPost(Name = "PostProductFinancial")]
        [ProducesResponseType((int)HttpStatusCode.OK,Type = typeof(FinancialProductOutputModel))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(string))]
        public IActionResult Post([Required][FromBody] AddFinancialProductInputModel productFinancialModel)
        {
            try
            {
                var response = _financialProductApp.AddFinancialProduct(productFinancialModel);
                return Ok(response);
            }catch(FormatException fe)
            {
                return StatusCode((int)HttpStatusCode.BadRequest,fe.Message);
            }
            catch(Exception ex)
            {
                return StatusCode(500,"Internal Error");
            }
           
        }

        [HttpPut(Name = "PutProductFinancial")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(string))]
        public IActionResult Put([Required][FromBody] UpdateFinancialProductInputModel productFinancialModel)
        {
            try
            {
                var response = _financialProductApp.UpdateFinancialProduct(productFinancialModel);
                return Ok("Success");
            }
            catch (FormatException fe)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, fe.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Error");
            }

        }



        [HttpGet(Name = "GetProductFinancial")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<GetFinancialProductOutputModel>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(string))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(string))]
        public IActionResult Get()
        {
            try
            {
                var response = _financialProductApp.GetFinancialProduct();
                return Ok(response);
            }
            catch (FormatException fe)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, fe.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Error");
            }

        }
    }
}
