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
namespace Xbim.Ifc4x3.ProfileResource
{
	public partial class @IfcTrapeziumProfileDef : IIfcTrapeziumProfileDef
	{

		[CrossSchemaAttribute(typeof(IIfcTrapeziumProfileDef), 4)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcTrapeziumProfileDef.BottomXDim 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(BottomXDim);
			} 
			set
			{
				BottomXDim = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTrapeziumProfileDef), 5)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcTrapeziumProfileDef.TopXDim 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(TopXDim);
			} 
			set
			{
				TopXDim = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTrapeziumProfileDef), 6)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcTrapeziumProfileDef.YDim 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(YDim);
			} 
			set
			{
				YDim = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTrapeziumProfileDef), 7)]
		Ifc4.MeasureResource.IfcLengthMeasure IIfcTrapeziumProfileDef.TopXOffset 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLengthMeasure(TopXOffset);
			} 
			set
			{
				TopXOffset = new MeasureResource.IfcLengthMeasure(value);
				
			}
		}
	//## Custom code
	//##
	}
}