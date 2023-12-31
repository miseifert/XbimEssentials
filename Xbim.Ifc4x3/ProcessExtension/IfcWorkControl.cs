// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.Kernel;
using Xbim.Ifc4x3.DateTimeResource;
using Xbim.Ifc4x3.MeasureResource;
using Xbim.Ifc4x3.ActorResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.ProcessExtension;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.ProcessExtension
{
	[ExpressType("IfcWorkControl", 185)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcWorkControl : IfcControl, IEquatable<@IfcWorkControl>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkControl(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_creators = new OptionalItemSet<IfcPerson>( this, 0,  8);
		}

		#region Explicit attribute fields
		private IfcDateTime _creationDate;
		private readonly OptionalItemSet<IfcPerson> _creators;
		private IfcLabel? _purpose;
		private IfcDuration? _duration;
		private IfcDuration? _totalFloat;
		private IfcDateTime _startTime;
		private IfcDateTime? _finishTime;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 19)]
		public IfcDateTime @CreationDate 
		{ 
			get 
			{
				if(_activated) return _creationDate;
				Activate();
				return _creationDate;
			} 
			set
			{
				SetValue( v =>  _creationDate = v, _creationDate, value,  "CreationDate", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 20)]
		public IOptionalItemSet<IfcPerson> @Creators 
		{ 
			get 
			{
				if(_activated) return _creators;
				Activate();
				return _creators;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 21)]
		public IfcLabel? @Purpose 
		{ 
			get 
			{
				if(_activated) return _purpose;
				Activate();
				return _purpose;
			} 
			set
			{
				SetValue( v =>  _purpose = v, _purpose, value,  "Purpose", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 22)]
		public IfcDuration? @Duration 
		{ 
			get 
			{
				if(_activated) return _duration;
				Activate();
				return _duration;
			} 
			set
			{
				SetValue( v =>  _duration = v, _duration, value,  "Duration", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 23)]
		public IfcDuration? @TotalFloat 
		{ 
			get 
			{
				if(_activated) return _totalFloat;
				Activate();
				return _totalFloat;
			} 
			set
			{
				SetValue( v =>  _totalFloat = v, _totalFloat, value,  "TotalFloat", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 24)]
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
				SetValue( v =>  _startTime = v, _startTime, value,  "StartTime", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 25)]
		public IfcDateTime? @FinishTime 
		{ 
			get 
			{
				if(_activated) return _finishTime;
				Activate();
				return _finishTime;
			} 
			set
			{
				SetValue( v =>  _finishTime = v, _finishTime, value,  "FinishTime", 13);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_creationDate = value.StringVal;
					return;
				case 7: 
					_creators.InternalAdd((IfcPerson)value.EntityVal);
					return;
				case 8: 
					_purpose = value.StringVal;
					return;
				case 9: 
					_duration = value.StringVal;
					return;
				case 10: 
					_totalFloat = value.StringVal;
					return;
				case 11: 
					_startTime = value.StringVal;
					return;
				case 12: 
					_finishTime = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWorkControl other)
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