using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    /// <summary>
    /// Account Entity
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Account identication
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Account username
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Account password
        /// </summary>
        public string Pass { get; set; }

        /// <summary>
        /// Account Reset Key
        /// </summary>
        public int RecoveryKey { get; set; }

        /// <summary>
        /// The birth day of the person, who owns this Account
        /// </summary>
        public DateOnly BirthDay { get; set; }
    }
}
