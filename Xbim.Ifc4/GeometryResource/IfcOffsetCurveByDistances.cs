// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcOffsetCurveByDistances
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcOffsetCurveByDistances : IIfcOffsetCurve
	{
		IItemSet<IIfcDistanceExpression> @OffsetValues { get; }
		IfcLabel? @Tag { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcOffsetCurveByDistances", 1351)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOffsetCurveByDistances : IfcOffsetCurve, IInstantiableEntity, IIfcOffsetCurveByDistances, IContainsEntityReferences, IEquatable<@IfcOffsetCurveByDistances>
	{
		#region IIfcOffsetCurveByDistances explicit implementation
		IItemSet<IIfcDistanceExpression> IIfcOffsetCurveByDistances.OffsetValues { 
			get { return new Common.Collections.ProxyItemSet<IfcDistanceExpression, IIfcDistanceExpression>( @OffsetValues); } 
		}	
		IfcLabel? IIfcOffsetCurveByDistances.Tag { 
 
			get { return @Tag; } 
			set { Tag = value;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOffsetCurveByDistances(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_offsetValues = new ItemSet<IfcDistanceExpression>( this, 0,  2);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcDistanceExpression> _offsetValues;
		private IfcLabel? _tag;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IItemSet<IfcDistanceExpression> @OffsetValues 
		{ 
			get 
			{
				if(_activated) return _offsetValues;
				Activate();
				return _offsetValues;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcLabel? @Tag 
		{ 
			get 
			{
				if(_activated) return _tag;
				Activate();
				return _tag;
			} 
			set
			{
				SetValue( v =>  _tag = v, _tag, value,  "Tag", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_offsetValues.InternalAdd((IfcDistanceExpression)value.EntityVal);
					return;
				case 2: 
					_tag = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOffsetCurveByDistances other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@BasisCurve != null)
					yield return @BasisCurve;
				foreach(var entity in @OffsetValues)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}