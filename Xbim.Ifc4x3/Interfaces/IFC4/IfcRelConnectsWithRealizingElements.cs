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
namespace Xbim.Ifc4x3.ProductExtension
{
	public partial class @IfcRelConnectsWithRealizingElements : IIfcRelConnectsWithRealizingElements
	{

		[CrossSchemaAttribute(typeof(IIfcRelConnectsWithRealizingElements), 8)]
		IItemSet<IIfcElement> IIfcRelConnectsWithRealizingElements.RealizingElements 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcElement, IIfcElement>(RealizingElements);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcRelConnectsWithRealizingElements), 9)]
		Ifc4.MeasureResource.IfcLabel? IIfcRelConnectsWithRealizingElements.ConnectionType 
		{ 
			get
			{
				if (!ConnectionType.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(ConnectionType.Value);
			} 
			set
			{
				ConnectionType = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	//##
	}
}