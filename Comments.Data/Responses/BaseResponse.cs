﻿using Comments.Data.Enums;
using Comments.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments.Data.Responses
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        /// <summary>
        /// Errors, warnings, success describing property
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
