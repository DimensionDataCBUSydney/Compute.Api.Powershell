// --------------------------------------------------------------------------------------------------------------------
// <copyright company="" file="GlobalSuppressions.cs">
//   
// </copyright>
// <summary>
//   GlobalSuppressions.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

[assembly:
	SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", 
		Target =
			"DD.CBU.Compute.Powershell.SessionStateExtensions.#SetDefaultComputeServiceConnection(System.Management.Automation.SessionState,System.String)"
		)]
[assembly:
	SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", 
		Target =
			"DD.CBU.Compute.Powershell.SessionStateExtensions.#GetDefaultComputeServiceConnection(System.Management.Automation.SessionState)"
		)]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Ip", Scope = "member", Target = "DD.CBU.Compute.Powershell.CaasServerDetails.#PrivateIp")]
