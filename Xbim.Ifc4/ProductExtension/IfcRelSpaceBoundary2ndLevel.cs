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
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProductExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelSpaceBoundary2ndLevel
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelSpaceBoundary2ndLevel : IIfcRelSpaceBoundary1stLevel
	{
		IIfcRelSpaceBoundary2ndLevel @CorrespondingBoundary { get; }
		IEnumerable<IIfcRelSpaceBoundary2ndLevel> @Corresponds {  get; }
	
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IfcRelSpaceBoundary2ndLevel", 1254)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelSpaceBoundary2ndLevel : IfcRelSpaceBoundary1stLevel, IInstantiableEntity, IIfcRelSpaceBoundary2ndLevel, IEquatable<@IfcRelSpaceBoundary2ndLevel>
	{
		#region IIfcRelSpaceBoundary2ndLevel explicit implementation
		IIfcRelSpaceBoundary2ndLevel IIfcRelSpaceBoundary2ndLevel.CorrespondingBoundary { get { return @CorrespondingBoundary; } }	
		 
		IEnumerable<IIfcRelSpaceBoundary2ndLevel> IIfcRelSpaceBoundary2ndLevel.Corresponds {  get { return @Corresponds; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelSpaceBoundary2ndLevel(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcRelSpaceBoundary2ndLevel _correspondingBoundary;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 12)]
		public IfcRelSpaceBoundary2ndLevel @CorrespondingBoundary 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _correspondingBoundary;
				((IPersistEntity)this).Activate(false);
				return _correspondingBoundary;
			} 
			set
			{
				SetValue( v =>  _correspondingBoundary = v, _correspondingBoundary, value,  "CorrespondingBoundary");
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("CorrespondingBoundary")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 13)]
		public IEnumerable<IfcRelSpaceBoundary2ndLevel> @Corresponds 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSpaceBoundary2ndLevel>(e => e.CorrespondingBoundary == this, "CorrespondingBoundary", this);
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
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 10: 
					_correspondingBoundary = (IfcRelSpaceBoundary2ndLevel)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelSpaceBoundary2ndLevel other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelSpaceBoundary2ndLevel
            var root = (@IfcRelSpaceBoundary2ndLevel)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelSpaceBoundary2ndLevel left, @IfcRelSpaceBoundary2ndLevel right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelSpaceBoundary2ndLevel left, @IfcRelSpaceBoundary2ndLevel right)
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