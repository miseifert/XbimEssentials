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
namespace Xbim.Ifc4x3.ControlExtension
{
	public partial class @IfcRelAssociatesConstraint : IIfcRelAssociatesConstraint
	{

		[CrossSchemaAttribute(typeof(IIfcRelAssociatesConstraint), 6)]
		Ifc4.MeasureResource.IfcLabel? IIfcRelAssociatesConstraint.Intent 
		{ 
			get
			{
				if (!Intent.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Intent.Value);
			} 
			set
			{
				Intent = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelAssociatesConstraint), 7)]
		IIfcConstraint IIfcRelAssociatesConstraint.RelatingConstraint 
		{ 
			get
			{
				return RelatingConstraint;
			} 
			set
			{
				RelatingConstraint = value as ConstraintResource.IfcConstraint;
				
			}
		}
	//## Custom code
	//##
	}
}