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

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.ProductExtension
{
	public partial class @IfcPort : IIfcPort
	{
		IEnumerable<IIfcRelConnectsPortToElement> IIfcPort.ContainedIn 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelConnectsPortToElement>(e => (e.RelatingPort as IfcPort) == this, "RelatingPort", this);
			} 
		}
		IEnumerable<IIfcRelConnectsPorts> IIfcPort.ConnectedFrom 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelConnectsPorts>(e => (e.RelatedPort as IfcPort) == this, "RelatedPort", this);
			} 
		}
		IEnumerable<IIfcRelConnectsPorts> IIfcPort.ConnectedTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelConnectsPorts>(e => (e.RelatingPort as IfcPort) == this, "RelatingPort", this);
			} 
		}
	//## Custom code
	//##
	}
}