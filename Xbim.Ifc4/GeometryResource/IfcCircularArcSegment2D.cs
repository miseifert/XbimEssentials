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
    /// Readonly interface for IfcCircularArcSegment2D
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCircularArcSegment2D : IIfcCurveSegment2D
	{
		IfcPositiveLengthMeasure @Radius { get;  set; }
		IfcBoolean @IsCCW { get;  set; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcCircularArcSegment2D", 1340)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCircularArcSegment2D : IfcCurveSegment2D, IInstantiableEntity, IIfcCircularArcSegment2D, IContainsEntityReferences, IEquatable<@IfcCircularArcSegment2D>
	{
		#region IIfcCircularArcSegment2D explicit implementation
		IfcPositiveLengthMeasure IIfcCircularArcSegment2D.Radius { 
 
			get { return @Radius; } 
			set { Radius = value;}
		}	
		IfcBoolean IIfcCircularArcSegment2D.IsCCW { 
 
			get { return @IsCCW; } 
			set { IsCCW = value;}
		}	
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCircularArcSegment2D(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _radius;
		private IfcBoolean _isCCW;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcPositiveLengthMeasure @Radius 
		{ 
			get 
			{
				if(_activated) return _radius;
				Activate();
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcBoolean @IsCCW 
		{ 
			get 
			{
				if(_activated) return _isCCW;
				Activate();
				return _isCCW;
			} 
			set
			{
				SetValue( v =>  _isCCW = v, _isCCW, value,  "IsCCW", 5);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_radius = value.RealVal;
					return;
				case 4: 
					_isCCW = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCircularArcSegment2D other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@StartPoint != null)
					yield return @StartPoint;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}