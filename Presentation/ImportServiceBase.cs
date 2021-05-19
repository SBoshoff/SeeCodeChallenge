// <copyright file="ImportServiceBase.cs" company="CitrusLime Ltd">
// Copyright (c) CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CustomerRewards2.DataMigration.Services.Base
{
    using System.Collections.Generic;
    using System.Net;

    using CitrusLime.CustomerRewards2.DataAccess.DataAccess;
    using CitrusLime.CustomerRewards2.DataAccess.Models;

    using Microsoft.Extensions.Logging;

    using Newtonsoft.Json;

    /// <summary>An import service base.</summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    public abstract class ImportServiceBase<T>
    {
        /// <summary>The exportendpoint.</summary>
        protected const string EXPORTENDPOINT = "/websrv/export/";

        /// <summary>The import entity last timestamps access.</summary>
        private readonly ImportEntityLastTimestampsAccess importEntityLastTimestampsAccess;

        /// <summary>Initialises a new instance of the <see cref="CitrusLime.CustomerRewards2.DataMigration.Services.Base.ImportServiceBase&lt;T&gt;"/> class.</summary>
        /// <param name="logger">The logger.</param>
        /// <param name="importEntityLastTimestampsAccess">The import entity last timestamps access.</param>
        public ImportServiceBase(ILogger logger, ImportEntityLastTimestampsAccess importEntityLastTimestampsAccess)
        {
            // DELETED
        }

        /// <summary>Gets the logger.</summary>
        /// <value>The logger.</value>
        protected ILogger Logger { get; }

        /// <summary>Gets time stamp.</summary>
        /// <param name="entityName">Name of the entity.</param>
        /// <returns>The time stamp.</returns>
        protected ImportEntityLastTimestamp GetTimeStamp(string entityName)
        {
            // DELETED
        }

        /// <summary>Gets account data.</summary>
        /// <param name="baseUrl">URL of the base.</param>
        /// <param name="entityName">Name of the entity.</param>
        /// <returns>The account data.</returns>
        protected ImportResults<T> GetDataToImport(string baseUrl, string entityName)
        {
            // DELETED
        }

        /// <summary>Initialises a new instance of the ImportServiceBase class.</summary>
        /// <param name="entityName">Name of the entity.</param>
        /// <param name="timeStamp">The time stamp.</param>
        protected void UpdateTimeStamp(string entityName, long timeStamp)
        {
            // DELETED
        }
    }
}
