using Phrases.Data.Dtos;
using Phrases.Data.Enums;
using Phrases.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phrases.Data.Responses
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        /// <summary>
        /// Errors and warnings describing property
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// Status of process, can be: OK, NotFound, InternalServerError
        /// </summary>
        public StatusCode StatusCode { get; set; }

        /// <summary>
        /// Received data from DAL
        /// </summary>
        public T Data { get; set; }
    }
}
