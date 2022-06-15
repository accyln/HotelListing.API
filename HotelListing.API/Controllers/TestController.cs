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
        public async Task<ActionResult<IEnumerable<GetTestSuiteDto>>> GetCountries()
        {
            var res = await testSuiteDal.GetAllAsync();
            //var countries = await _countriesRepository.GetAllAsync();
            var records = _mapper.Map<List<GetTestSuiteDto>>(res);
            return Ok(records);
        }

        [HttpPost]
        public async Task<ActionResult<TestSuite>> PostCountry(TestSuiteAddDto createCountryDto)
        {
            var country = _mapper.Map<TestSuite>(createCountryDto);

            //await _countriesRepository.AddAsync(country);

            return CreatedAtAction("GetCountry", new { id = country.Id }, country);
        }
    }
}
