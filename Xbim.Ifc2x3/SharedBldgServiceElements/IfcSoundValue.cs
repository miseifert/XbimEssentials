// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.TimeSeriesResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.SharedBldgServiceElements;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.SharedBldgServiceElements
{
	[ExpressType("IfcSoundValue", 266)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSoundValue : IfcPropertySetDefinition, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcSoundValue>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSoundValue(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcTimeSeries _soundLevelTimeSeries;
		private IfcFrequencyMeasure _frequency;
		private IfcDerivedMeasureValue _soundLevelSingleValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 8)]
		public IfcTimeSeries @SoundLevelTimeSeries 
		{ 
			get 
			{
				if(_activated) return _soundLevelTimeSeries;
				Activate();
				return _soundLevelTimeSeries;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _soundLevelTimeSeries = v, _soundLevelTimeSeries, value,  "SoundLevelTimeSeries", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcFrequencyMeasure @Frequency 
		{ 
			get 
			{
				if(_activated) return _frequency;
				Activate();
				return _frequency;
			} 
			set
			{
				SetValue( v =>  _frequency = v, _frequency, value,  "Frequency", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 10)]
		public IfcDerivedMeasureValue @SoundLevelSingleValue 
		{ 
			get 
			{
				if(_activated) return _soundLevelSingleValue;
				Activate();
				return _soundLevelSingleValue;
			} 
			set
			{
				SetValue( v =>  _soundLevelSingleValue = v, _soundLevelSingleValue, value,  "SoundLevelSingleValue", 7);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_soundLevelTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 5: 
					_frequency = value.RealVal;
					return;
				case 6: 
					_soundLevelSingleValue = (IfcDerivedMeasureValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSoundValue other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@SoundLevelTimeSeries != null)
					yield return @SoundLevelTimeSeries;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}