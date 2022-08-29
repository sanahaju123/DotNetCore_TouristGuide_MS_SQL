﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristGuide.DataLayer;
using TouristGuide.Entities;

namespace TouristGuide.BusinessLayer.Services.Repository
{
    public class TourguideRepository : ITourguideRepository
    {
        /// <summary>
        /// Creating referance variable of TouristguideDbContext and injecting in TourguideRepository constructor,
        /// using this varaible we are performing All CURD operation
        /// </summary>
        private readonly TouristguideDbContext _tgDbContext;
        public TourguideRepository(TouristguideDbContext touristguideDbContext)
        {
            _tgDbContext = touristguideDbContext;
        }


        /// <summary>
        /// Show list of place and destination on Menu Bar
        /// </summary>
        /// <returns>List of Destination</returns>
        public IList<Destination> DestinationList()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get Place by Destination id as well all placce on Index page of Tourist controller
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Place>> GetAllPlaces(int? Id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get place details on clicking Continue reading link on place view
        /// </summary>
        /// <param name="placeId"></param>
        /// <returns></returns>
        public async Task<Place> GetPlaceById(int placeId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Hire a tour guide for better assistant while traveling
        /// </summary>
        /// <param name="tourGuide"></param>
        /// <returns></returns>
        public async Task<TourGuide> HireTourGuide(TourGuide tourGuide)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Some quick information about india for visitor from InMemory Db
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AboutIndia>> KnowAboutIndia()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Place by Attraction tho show on while search in Db Collection
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Place>> PlaceByAttraction(string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Show your some quick information and Tour Guide Booking Id
        /// </summary>
        /// <param name="tourId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<TourGuide>> TourGuideInformation(int tourId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
