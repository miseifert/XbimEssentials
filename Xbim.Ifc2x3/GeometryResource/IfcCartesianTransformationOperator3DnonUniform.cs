// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.GeometryResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IfcCartesianTransformationOperator3DnonUniform", 479)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianTransformationOperator3DnonUniform : IfcCartesianTransformationOperator3D, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcCartesianTransformationOperator3DnonUniform>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator3DnonUniform(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private double? _scale2;
		private double? _scale3;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public double? @Scale2 
		{ 
			get 
			{
				if(_activated) return _scale2;
				Activate();
				return _scale2;
			} 
			set
			{
				SetValue( v =>  _scale2 = v, _scale2, value,  "Scale2", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public double? @Scale3 
		{ 
			get 
			{
				if(_activated) return _scale3;
				Activate();
				return _scale3;
			} 
			set
			{
				SetValue( v =>  _scale3 = v, _scale3, value,  "Scale3", 7);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public double @Scl2 
		{
			get 
			{
				//## Getter for Scl2
                return Scale2 ?? Scl;
				//##
			}
		}

		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public double @Scl3 
		{
			get 
			{
				//## Getter for Scl3
                return Scale3 ?? Scl;
				//##
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_scale2 = value.RealVal;
					return;
				case 6: 
					_scale3 = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCartesianTransformationOperator3DnonUniform other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Axis1 != null)
					yield return @Axis1;
				if (@Axis2 != null)
					yield return @Axis2;
				if (@LocalOrigin != null)
					yield return @LocalOrigin;
				if (@Axis3 != null)
					yield return @Axis3;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}