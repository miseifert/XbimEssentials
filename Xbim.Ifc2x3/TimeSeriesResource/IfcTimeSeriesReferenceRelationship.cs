// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.TimeSeriesResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.TimeSeriesResource
{
	[ExpressType("IfcTimeSeriesReferenceRelationship", 673)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTimeSeriesReferenceRelationship : PersistEntity, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcTimeSeriesReferenceRelationship>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTimeSeriesReferenceRelationship(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_timeSeriesReferences = new ItemSet<IfcDocumentSelect>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcTimeSeries _referencedTimeSeries;
		private readonly ItemSet<IfcDocumentSelect> _timeSeriesReferences;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcTimeSeries @ReferencedTimeSeries 
		{ 
			get 
			{
				if(_activated) return _referencedTimeSeries;
				Activate();
				return _referencedTimeSeries;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _referencedTimeSeries = v, _referencedTimeSeries, value,  "ReferencedTimeSeries", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 2)]
		public IItemSet<IfcDocumentSelect> @TimeSeriesReferences 
		{ 
			get 
			{
				if(_activated) return _timeSeriesReferences;
				Activate();
				return _timeSeriesReferences;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_referencedTimeSeries = (IfcTimeSeries)(value.EntityVal);
					return;
				case 1: 
					_timeSeriesReferences.InternalAdd((IfcDocumentSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTimeSeriesReferenceRelationship other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ReferencedTimeSeries != null)
					yield return @ReferencedTimeSeries;
				foreach(var entity in @TimeSeriesReferences)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ReferencedTimeSeries != null)
					yield return @ReferencedTimeSeries;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}