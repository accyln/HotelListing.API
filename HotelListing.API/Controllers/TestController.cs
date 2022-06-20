using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.Models;
using HotelListing.API.Repository.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITestSuiteDal testSuiteDal;
        public TestController(IMapper mapper,  ITestSuiteDal testSuiteDal)
        {
            this._mapper = mapper;
            this.testSuiteDal = testSuiteDal;

        }


        [HttpGet]
        [Route("GetCountries")]
        [ApiVersion("1.0")]
        public async Task<ActionResult<IEnumerable<GetTestSuiteDto>>> GetCountries()
        {
           
                var res = await testSuiteDal.GetAsync(12);
                res.ModulId = 1;    
                //var countries = await _countriesRepository.GetAllAsync();
                var records = _mapper.Map<List<GetTestSuiteDto>>(res);
                return Ok(records);
           
        }

        [HttpPost]
        [Route("PostCountry")]
        [ApiVersion("1.0")]
        public async Task<ActionResult<TestSuite>> PostCountry(TestSuiteAddDto createCountryDto)
        {
            var country = _mapper.Map<TestSuite>(createCountryDto);

            //await _countriesRepository.AddAsync(country);

            return CreatedAtAction("GetCountry", new { id = country.Id }, country);
        }
    }
}
