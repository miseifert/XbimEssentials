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
namespace Xbim.Ifc4x3.PresentationAppearanceResource
{
	public partial class @IfcColourRgb : IIfcColourRgb
	{

		[CrossSchemaAttribute(typeof(IIfcColourRgb), 2)]
		Ifc4.MeasureResource.IfcNormalisedRatioMeasure IIfcColourRgb.Red 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure(Red);
			} 
			set
			{
				Red = new MeasureResource.IfcNormalisedRatioMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcColourRgb), 3)]
		Ifc4.MeasureResource.IfcNormalisedRatioMeasure IIfcColourRgb.Green 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure(Green);
			} 
			set
			{
				Green = new MeasureResource.IfcNormalisedRatioMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcColourRgb), 4)]
		Ifc4.MeasureResource.IfcNormalisedRatioMeasure IIfcColourRgb.Blue 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure(Blue);
			} 
			set
			{
				Blue = new MeasureResource.IfcNormalisedRatioMeasure(value);
				
			}
		}
	//## Custom code
	//##
	}
}