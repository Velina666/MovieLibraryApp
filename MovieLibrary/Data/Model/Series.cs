using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    /// <summary>
    /// Series entity
    /// </summary>
    public class Series
    {
        /// <summary>
        /// The id of the person who add a film
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the added Series
        /// </summary>
        public string TitleOfSeries { get; set; }

        /// <summary>
        /// The number of seasons
        /// </summary>
        public int Seasons { get; set; }

        /// <summary>
        /// The year when comes out the first season of the series
        /// </summary>
        public int SeriesYaer { get; set; }

        /// <summary>
        /// The type of the film
        /// </summary>
        public string SeriesType { get; set; }

        /// <summary>
        /// User evaluation for the series
        /// </summary>
        public int StarsForSeries { get; set; }

        /// <summary>
        /// The rating of the series
        /// </summary>
        public double RateForSeries { get; set; }
    }
}
