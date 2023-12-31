// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ConstraintResource;
using Xbim.Ifc4.PropertyResource;
using Xbim.Ifc4.ExternalReferenceResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.DateTimeResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTimeSeries
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTimeSeries : IPersistEntity, IfcMetricValueSelect, IfcObjectReferenceSelect, IfcResourceObjectSelect
	{
		IfcLabel @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IfcDateTime @StartTime { get;  set; }
		IfcDateTime @EndTime { get;  set; }
		IfcTimeSeriesDataTypeEnum @TimeSeriesDataType { get;  set; }
		IfcDataOriginEnum @DataOrigin { get;  set; }
		IfcLabel? @UserDefinedDataOrigin { get;  set; }
		IIfcUnit @Unit { get;  set; }
		IEnumerable<IIfcExternalReferenceRelationship> @HasExternalReference {  get; }
	
	}
}

namespace Xbim.Ifc4.DateTimeResource
{
	[ExpressType("IfcTimeSeries", 418)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcTimeSeries : PersistEntity, IIfcTimeSeries, IEquatable<@IfcTimeSeries>
	{
		#region IIfcTimeSeries explicit implementation
		IfcLabel IIfcTimeSeries.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcTimeSeries.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IfcDateTime IIfcTimeSeries.StartTime { 
 
			get { return @StartTime; } 
			set { StartTime = value;}
		}	
		IfcDateTime IIfcTimeSeries.EndTime { 
 
			get { return @EndTime; } 
			set { EndTime = value;}
		}	
		IfcTimeSeriesDataTypeEnum IIfcTimeSeries.TimeSeriesDataType { 
 
			get { return @TimeSeriesDataType; } 
			set { TimeSeriesDataType = value;}
		}	
		IfcDataOriginEnum IIfcTimeSeries.DataOrigin { 
 
			get { return @DataOrigin; } 
			set { DataOrigin = value;}
		}	
		IfcLabel? IIfcTimeSeries.UserDefinedDataOrigin { 
 
			get { return @UserDefinedDataOrigin; } 
			set { UserDefinedDataOrigin = value;}
		}	
		IIfcUnit IIfcTimeSeries.Unit { 
 
 
			get { return @Unit; } 
			set { Unit = value as IfcUnit;}
		}	
		IEnumerable<IIfcExternalReferenceRelationship> IIfcTimeSeries.HasExternalReference {  get { return @HasExternalReference; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTimeSeries(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcText? _description;
		private IfcDateTime _startTime;
		private IfcDateTime _endTime;
		private IfcTimeSeriesDataTypeEnum _timeSeriesDataType;
		private IfcDataOriginEnum _dataOrigin;
		private IfcLabel? _userDefinedDataOrigin;
		private IfcUnit _unit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcDateTime @StartTime 
		{ 
			get 
			{
				if(_activated) return _startTime;
				Activate();
				return _startTime;
			} 
			set
			{
				SetValue( v =>  _startTime = v, _startTime, value,  "StartTime", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcDateTime @EndTime 
		{ 
			get 
			{
				if(_activated) return _endTime;
				Activate();
				return _endTime;
			} 
			set
			{
				SetValue( v =>  _endTime = v, _endTime, value,  "EndTime", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 5)]
		public IfcTimeSeriesDataTypeEnum @TimeSeriesDataType 
		{ 
			get 
			{
				if(_activated) return _timeSeriesDataType;
				Activate();
				return _timeSeriesDataType;
			} 
			set
			{
				SetValue( v =>  _timeSeriesDataType = v, _timeSeriesDataType, value,  "TimeSeriesDataType", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 6)]
		public IfcDataOriginEnum @DataOrigin 
		{ 
			get 
			{
				if(_activated) return _dataOrigin;
				Activate();
				return _dataOrigin;
			} 
			set
			{
				SetValue( v =>  _dataOrigin = v, _dataOrigin, value,  "DataOrigin", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcLabel? @UserDefinedDataOrigin 
		{ 
			get 
			{
				if(_activated) return _userDefinedDataOrigin;
				Activate();
				return _userDefinedDataOrigin;
			} 
			set
			{
				SetValue( v =>  _userDefinedDataOrigin = v, _userDefinedDataOrigin, value,  "UserDefinedDataOrigin", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 8)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(_activated) return _unit;
				Activate();
				return _unit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _unit = v, _unit, value,  "Unit", 8);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedResourceObjects")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 9)]
		public IEnumerable<IfcExternalReferenceRelationship> @HasExternalReference 
		{ 
			get 
			{
				return Model.Instances.Where<IfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_startTime = value.StringVal;
					return;
				case 3: 
					_endTime = value.StringVal;
					return;
				case 4: 
                    _timeSeriesDataType = (IfcTimeSeriesDataTypeEnum) System.Enum.Parse(typeof (IfcTimeSeriesDataTypeEnum), value.EnumVal, true);
					return;
				case 5: 
                    _dataOrigin = (IfcDataOriginEnum) System.Enum.Parse(typeof (IfcDataOriginEnum), value.EnumVal, true);
					return;
				case 6: 
					_userDefinedDataOrigin = value.StringVal;
					return;
				case 7: 
					_unit = (IfcUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTimeSeries other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}