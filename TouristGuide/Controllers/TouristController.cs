using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TouristGuide.BusinessLayer.Interfaces;
using TouristGuide.BusinessLayer.ViewModels;
using TouristGuide.Entities;

namespace TouristGuide.Controllers
{
    [ApiController]
    public class TouristController : ControllerBase
    {
        /// <summary>
        /// Creating referance variable of ITourguideServices and injecting in TouristController constructor
        /// </summary>
        private readonly ITourguideServices _tgServices;
        public TouristController(ITourguideServices tourguideServices)
        {
            _tgServices = tourguideServices;
        }

        /// <summary>
        /// Get place full details using this method, on details view
        /// </summary>
        /// <param name="placeId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("place-details")]
        public async Task<IActionResult> Details(int placeId)
        {
            //do code here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Post Method for Hire Tour Guide
        /// </summary>
        /// <param name="tourGuide"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("hire-tour-guide")]
        public async Task<IActionResult> HireTourGuide(TourGuide tourGuide)
        {
            //do code here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Tour Guide Infromation
        /// </summary>
        /// <param name="tourId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("tour-guide-info")]
        public async Task<IActionResult> TourGuideInfo(int tourId)
        {
            //do code here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Know about India Vist using this method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("about-india")]
        public async Task<IActionResult> AboutIndia()
        {
            //do code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("contact-us")]
        public IActionResult ContactUs()
        {
            //do code here
            throw new NotImplementedException();
        }
    }
}
