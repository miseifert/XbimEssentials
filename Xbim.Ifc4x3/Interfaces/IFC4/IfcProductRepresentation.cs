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
namespace Xbim.Ifc4x3.RepresentationResource
{
	public partial class @IfcProductRepresentation : IIfcProductRepresentation
	{

		[CrossSchemaAttribute(typeof(IIfcProductRepresentation), 1)]
		Ifc4.MeasureResource.IfcLabel? IIfcProductRepresentation.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
			set
			{
				Name = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcProductRepresentation), 2)]
		Ifc4.MeasureResource.IfcText? IIfcProductRepresentation.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcProductRepresentation), 3)]
		IItemSet<IIfcRepresentation> IIfcProductRepresentation.Representations 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcRepresentation, IIfcRepresentation>(Representations);
			} 
		}
	//## Custom code
	//##
	}
}