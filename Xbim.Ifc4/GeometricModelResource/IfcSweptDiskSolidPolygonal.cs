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
using Xbim.Ifc4.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSweptDiskSolidPolygonal
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSweptDiskSolidPolygonal : IIfcSweptDiskSolid
	{
		IfcPositiveLengthMeasure? @FilletRadius { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IfcSweptDiskSolidPolygonal", 1289)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSweptDiskSolidPolygonal : IfcSweptDiskSolid, IInstantiableEntity, IIfcSweptDiskSolidPolygonal, IContainsEntityReferences, IEquatable<@IfcSweptDiskSolidPolygonal>
	{
		#region IIfcSweptDiskSolidPolygonal explicit implementation
		IfcPositiveLengthMeasure? IIfcSweptDiskSolidPolygonal.FilletRadius { 
 
			get { return @FilletRadius; } 
			set { FilletRadius = value;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSweptDiskSolidPolygonal(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _filletRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcPositiveLengthMeasure? @FilletRadius 
		{ 
			get 
			{
				if(_activated) return _filletRadius;
				Activate();
				return _filletRadius;
			} 
			set
			{
				SetValue( v =>  _filletRadius = v, _filletRadius, value,  "FilletRadius", 6);
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
					_filletRadius = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSweptDiskSolidPolygonal other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Directrix != null)
					yield return @Directrix;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}