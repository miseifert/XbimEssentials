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
namespace Xbim.Ifc4x3.DateTimeResource
{
	public partial class @IfcIrregularTimeSeriesValue : IIfcIrregularTimeSeriesValue
	{

		[CrossSchemaAttribute(typeof(IIfcIrregularTimeSeriesValue), 1)]
		Ifc4.DateTimeResource.IfcDateTime IIfcIrregularTimeSeriesValue.TimeStamp 
		{ 
			get
			{
				return new Ifc4.DateTimeResource.IfcDateTime(TimeStamp);
			} 
			set
			{
				TimeStamp = new IfcDateTime(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcIrregularTimeSeriesValue), 2)]
		IItemSet<IIfcValue> IIfcIrregularTimeSeriesValue.ListValues 
		{ 
			get
			{
			
				return _listValuesIfc4 ?? (_listValuesIfc4 = new Common.Collections.ExtendedItemSet<MeasureResource.IfcValue, IIfcValue>(
                    ListValues, 
                    new ItemSet<IIfcValue>(this, 0, -2), 
                    v => v.ToIfc4(), 
                    v => v.ToIfc3()));
			} 
		}

		//private field to hold any extended data
		private IItemSet<IIfcValue> _listValuesIfc4;
	//## Custom code
	//##
	}
}