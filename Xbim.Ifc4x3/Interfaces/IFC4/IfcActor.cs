// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.Kernel
{
	public partial class @IfcActor : IIfcActor
	{

		[CrossSchemaAttribute(typeof(IIfcActor), 6)]
		IIfcActorSelect IIfcActor.TheActor 
		{ 
			get
			{
				if (TheActor == null) return null;
				var ifcorganization = TheActor as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifcperson = TheActor as ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcpersonandorganization = TheActor as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				return null;
			} 
			set
			{
				if (value == null)
				{
					TheActor = null;
					return;
				}	
				var ifcorganization = value as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
				{
					TheActor = ifcorganization;
					return;
				}
				var ifcperson = value as ActorResource.IfcPerson;
				if (ifcperson != null) 
				{
					TheActor = ifcperson;
					return;
				}
				var ifcpersonandorganization = value as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
				{
					TheActor = ifcpersonandorganization;
					return;
				}
				
			}
		}
		IEnumerable<IIfcRelAssignsToActor> IIfcActor.IsActingUpon 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssignsToActor>(e => (e.RelatingActor as IfcActor) == this, "RelatingActor", this);
			} 
		}
	//## Custom code
	//##
	}
}