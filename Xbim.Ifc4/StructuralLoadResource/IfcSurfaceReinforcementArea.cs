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
using Xbim.Ifc4.StructuralLoadResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceReinforcementArea
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceReinforcementArea : IIfcStructuralLoadOrResult
	{
		IItemSet<IfcLengthMeasure> @SurfaceReinforcement1 { get; }
		IItemSet<IfcLengthMeasure> @SurfaceReinforcement2 { get; }
		IfcRatioMeasure? @ShearReinforcement { get;  set; }
	
	}
}

namespace Xbim.Ifc4.StructuralLoadResource
{
	[ExpressType("IfcSurfaceReinforcementArea", 1288)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceReinforcementArea : IfcStructuralLoadOrResult, IInstantiableEntity, IIfcSurfaceReinforcementArea, IEquatable<@IfcSurfaceReinforcementArea>
	{
		#region IIfcSurfaceReinforcementArea explicit implementation
		IItemSet<IfcLengthMeasure> IIfcSurfaceReinforcementArea.SurfaceReinforcement1 { 
			get { return @SurfaceReinforcement1; } 
		}	
		IItemSet<IfcLengthMeasure> IIfcSurfaceReinforcementArea.SurfaceReinforcement2 { 
			get { return @SurfaceReinforcement2; } 
		}	
		IfcRatioMeasure? IIfcSurfaceReinforcementArea.ShearReinforcement { 
 
			get { return @ShearReinforcement; } 
			set { ShearReinforcement = value;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceReinforcementArea(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_surfaceReinforcement1 = new OptionalItemSet<IfcLengthMeasure>( this, 3,  2);
			_surfaceReinforcement2 = new OptionalItemSet<IfcLengthMeasure>( this, 3,  3);
		}

		#region Explicit attribute fields
		private readonly OptionalItemSet<IfcLengthMeasure> _surfaceReinforcement1;
		private readonly OptionalItemSet<IfcLengthMeasure> _surfaceReinforcement2;
		private IfcRatioMeasure? _shearReinforcement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 2 }, new int [] { 3 }, 2)]
		public IOptionalItemSet<IfcLengthMeasure> @SurfaceReinforcement1 
		{ 
			get 
			{
				if(_activated) return _surfaceReinforcement1;
				Activate();
				return _surfaceReinforcement1;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 2 }, new int [] { 3 }, 3)]
		public IOptionalItemSet<IfcLengthMeasure> @SurfaceReinforcement2 
		{ 
			get 
			{
				if(_activated) return _surfaceReinforcement2;
				Activate();
				return _surfaceReinforcement2;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcRatioMeasure? @ShearReinforcement 
		{ 
			get 
			{
				if(_activated) return _shearReinforcement;
				Activate();
				return _shearReinforcement;
			} 
			set
			{
				SetValue( v =>  _shearReinforcement = v, _shearReinforcement, value,  "ShearReinforcement", 4);
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
					_surfaceReinforcement1.InternalAdd(value.RealVal);
					return;
				case 2: 
					_surfaceReinforcement2.InternalAdd(value.RealVal);
					return;
				case 3: 
					_shearReinforcement = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceReinforcementArea other)
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