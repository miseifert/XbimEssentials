// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.RepresentationResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.RepresentationResource
{
	[ExpressType("IfcMapConversion", 1200)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMapConversion : IfcCoordinateOperation, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcMapConversion>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMapConversion(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _eastings;
		private IfcLengthMeasure _northings;
		private IfcLengthMeasure _orthogonalHeight;
		private IfcReal? _xAxisAbscissa;
		private IfcReal? _xAxisOrdinate;
		private IfcReal? _scale;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLengthMeasure @Eastings 
		{ 
			get 
			{
				if(_activated) return _eastings;
				Activate();
				return _eastings;
			} 
			set
			{
				SetValue( v =>  _eastings = v, _eastings, value,  "Eastings", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLengthMeasure @Northings 
		{ 
			get 
			{
				if(_activated) return _northings;
				Activate();
				return _northings;
			} 
			set
			{
				SetValue( v =>  _northings = v, _northings, value,  "Northings", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcLengthMeasure @OrthogonalHeight 
		{ 
			get 
			{
				if(_activated) return _orthogonalHeight;
				Activate();
				return _orthogonalHeight;
			} 
			set
			{
				SetValue( v =>  _orthogonalHeight = v, _orthogonalHeight, value,  "OrthogonalHeight", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcReal? @XAxisAbscissa 
		{ 
			get 
			{
				if(_activated) return _xAxisAbscissa;
				Activate();
				return _xAxisAbscissa;
			} 
			set
			{
				SetValue( v =>  _xAxisAbscissa = v, _xAxisAbscissa, value,  "XAxisAbscissa", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcReal? @XAxisOrdinate 
		{ 
			get 
			{
				if(_activated) return _xAxisOrdinate;
				Activate();
				return _xAxisOrdinate;
			} 
			set
			{
				SetValue( v =>  _xAxisOrdinate = v, _xAxisOrdinate, value,  "XAxisOrdinate", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcReal? @Scale 
		{ 
			get 
			{
				if(_activated) return _scale;
				Activate();
				return _scale;
			} 
			set
			{
				SetValue( v =>  _scale = v, _scale, value,  "Scale", 8);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_eastings = value.RealVal;
					return;
				case 3: 
					_northings = value.RealVal;
					return;
				case 4: 
					_orthogonalHeight = value.RealVal;
					return;
				case 5: 
					_xAxisAbscissa = value.RealVal;
					return;
				case 6: 
					_xAxisOrdinate = value.RealVal;
					return;
				case 7: 
					_scale = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMapConversion other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@SourceCRS != null)
					yield return @SourceCRS;
				if (@TargetCRS != null)
					yield return @TargetCRS;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@SourceCRS != null)
					yield return @SourceCRS;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}