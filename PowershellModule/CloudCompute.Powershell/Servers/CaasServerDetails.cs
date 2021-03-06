﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CaasServerDetails.cs" company="">
//   
// </copyright>
// <summary>
//   The caas server details.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using DD.CBU.Compute.Api.Contracts.Image;
using DD.CBU.Compute.Api.Contracts.Network;
using DD.CBU.Compute.Api.Contracts.Network20;

namespace DD.CBU.Compute.Powershell
{
    using System.Management.Automation;

    /// <summary>
	///     The caas server details.
	/// </summary>
	public class CaasServerDetails
	{
		/// <summary>
		///     Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///     Gets or sets the description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		///     Gets or sets the administrator password.
		/// </summary>
		public string AdministratorPassword { get; set; }

		/// <summary>
		///     Gets or sets a value indicating whether is started.
		/// </summary>
		public bool IsStarted { get; set; }

		/// <summary>
		///     Gets or sets the network.
		/// </summary>
		public NetworkWithLocationsNetwork Network { get; set; }
      
        /// <summary>
        ///     Gets or sets the image.
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        ///     Gets or sets the private ip.
        /// </summary>
        public string PrivateIp { get; set; }

        /// <summary>
        ///     Gets or sets the primary Nic Connection State.
        /// </summary>
		public bool? PrimaryNicConnected { get; set; }

        /// <summary>
        ///     Gets or sets the network domain.
        /// </summary>
        public NetworkDomainType NetworkDomain { get; set; }

        /// <summary>
        /// Primary Vlan
        /// </summary>
        public VlanType PrimaryVlan { get; set; }

        /// <summary>
        /// Cpu details
        /// </summary>
        public DeployServerTypeCpu CpuDetails { get; set; }

        /// <summary>
        ///     The Primary DNS for the machine
        /// </summary>
        public string PrimaryDns { get; set; }

        /// <summary>
        ///     The Secondary DNS for the machine
        /// </summary>
        public string SecondaryDns { get; set; }

        /// <summary>
        /// Memory of the machine in GB
        /// </summary>
        public uint MemoryGb { get; set; }

        /// <summary>
        ///     The  Microsoft time zone for windows machine
        /// </summary>
        public string MicrosoftTimeZone { get; set; }

        /// <summary>
        ///     The  Microsoft time zone for windows machine
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Set the destination cluster for the new CaaS Server")]
        public string ClusterId { get; set; }

        /// <summary>
        ///     Gets or sets the internal disk details.
        /// </summary>
        internal List<CaasServerDiskDetails> InternalDiskDetails { get; set; }

		/// <summary>
		///     Gets the disk details.
		/// </summary>
		public CaasServerDiskDetails[] DiskDetails
		{
			get
			{
				if (InternalDiskDetails != null)
					return InternalDiskDetails.ToArray();
				return null;
			}
		}
	}
}