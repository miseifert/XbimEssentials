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
using Xbim.Ifc4.GeometricConstraintResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConnectionPointEccentricity
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConnectionPointEccentricity : IIfcConnectionPointGeometry
	{
		IfcLengthMeasure? @EccentricityInX { get; }
		IfcLengthMeasure? @EccentricityInY { get; }
		IfcLengthMeasure? @EccentricityInZ { get; }
	
	}
}

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[ExpressType("IfcConnectionPointEccentricity", 405)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionPointEccentricity : IfcConnectionPointGeometry, IInstantiableEntity, IIfcConnectionPointEccentricity, IEquatable<@IfcConnectionPointEccentricity>
	{
		#region IIfcConnectionPointEccentricity explicit implementation
		IfcLengthMeasure? IIfcConnectionPointEccentricity.EccentricityInX { get { return @EccentricityInX; } }	
		IfcLengthMeasure? IIfcConnectionPointEccentricity.EccentricityInY { get { return @EccentricityInY; } }	
		IfcLengthMeasure? IIfcConnectionPointEccentricity.EccentricityInZ { get { return @EccentricityInZ; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionPointEccentricity(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure? _eccentricityInX;
		private IfcLengthMeasure? _eccentricityInY;
		private IfcLengthMeasure? _eccentricityInZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcLengthMeasure? @EccentricityInX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _eccentricityInX;
				((IPersistEntity)this).Activate(false);
				return _eccentricityInX;
			} 
			set
			{
				SetValue( v =>  _eccentricityInX = v, _eccentricityInX, value,  "EccentricityInX");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcLengthMeasure? @EccentricityInY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _eccentricityInY;
				((IPersistEntity)this).Activate(false);
				return _eccentricityInY;
			} 
			set
			{
				SetValue( v =>  _eccentricityInY = v, _eccentricityInY, value,  "EccentricityInY");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcLengthMeasure? @EccentricityInZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _eccentricityInZ;
				((IPersistEntity)this).Activate(false);
				return _eccentricityInZ;
			} 
			set
			{
				SetValue( v =>  _eccentricityInZ = v, _eccentricityInZ, value,  "EccentricityInZ");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_eccentricityInX = value.RealVal;
					return;
				case 3: 
					_eccentricityInY = value.RealVal;
					return;
				case 4: 
					_eccentricityInZ = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConnectionPointEccentricity other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConnectionPointEccentricity
            var root = (@IfcConnectionPointEccentricity)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConnectionPointEccentricity left, @IfcConnectionPointEccentricity right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConnectionPointEccentricity left, @IfcConnectionPointEccentricity right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}