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
namespace Xbim.Ifc4x3.ProcessExtension
{
	public partial class @IfcWorkCalendar : IIfcWorkCalendar
	{

		[CrossSchemaAttribute(typeof(IIfcWorkCalendar), 7)]
		IItemSet<IIfcWorkTime> IIfcWorkCalendar.WorkingTimes 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<DateTimeResource.IfcWorkTime, IIfcWorkTime>(WorkingTimes);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcWorkCalendar), 8)]
		IItemSet<IIfcWorkTime> IIfcWorkCalendar.ExceptionTimes 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<DateTimeResource.IfcWorkTime, IIfcWorkTime>(ExceptionTimes);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcWorkCalendar), 9)]
		Ifc4.Interfaces.IfcWorkCalendarTypeEnum? IIfcWorkCalendar.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcWorkCalendarTypeEnum.FIRSTSHIFT:
						return Ifc4.Interfaces.IfcWorkCalendarTypeEnum.FIRSTSHIFT;
					case IfcWorkCalendarTypeEnum.SECONDSHIFT:
						return Ifc4.Interfaces.IfcWorkCalendarTypeEnum.SECONDSHIFT;
					case IfcWorkCalendarTypeEnum.THIRDSHIFT:
						return Ifc4.Interfaces.IfcWorkCalendarTypeEnum.THIRDSHIFT;
					case IfcWorkCalendarTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcWorkCalendarTypeEnum.USERDEFINED;
					case IfcWorkCalendarTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcWorkCalendarTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcWorkCalendarTypeEnum.FIRSTSHIFT:
						PredefinedType = IfcWorkCalendarTypeEnum.FIRSTSHIFT;
						return;
					case Ifc4.Interfaces.IfcWorkCalendarTypeEnum.SECONDSHIFT:
						PredefinedType = IfcWorkCalendarTypeEnum.SECONDSHIFT;
						return;
					case Ifc4.Interfaces.IfcWorkCalendarTypeEnum.THIRDSHIFT:
						PredefinedType = IfcWorkCalendarTypeEnum.THIRDSHIFT;
						return;
					case Ifc4.Interfaces.IfcWorkCalendarTypeEnum.USERDEFINED:
						PredefinedType = IfcWorkCalendarTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcWorkCalendarTypeEnum.NOTDEFINED:
						PredefinedType = IfcWorkCalendarTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}