// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.StructuralLoadResource
{
	public partial class @IfcBoundaryEdgeCondition : IIfcBoundaryEdgeCondition
	{

		[CrossSchemaAttribute(typeof(IIfcBoundaryEdgeCondition), 2)]
		IIfcModulusOfTranslationalSubgradeReactionSelect IIfcBoundaryEdgeCondition.TranslationalStiffnessByLengthX 
		{ 
			get
			{
				if (TranslationalStiffnessByLengthX == null) return null;
				if (TranslationalStiffnessByLengthX is MeasureResource.IfcBoolean) 
					return new Ifc4.MeasureResource.IfcBoolean((MeasureResource.IfcBoolean)TranslationalStiffnessByLengthX);
				if (TranslationalStiffnessByLengthX is MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure((MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure)TranslationalStiffnessByLengthX);
				return null;
			} 
			set
			{
				if (value == null)
				{
					TranslationalStiffnessByLengthX = null;
					return;
				}	
				if (value is Ifc4.MeasureResource.IfcBoolean) 
				{
					TranslationalStiffnessByLengthX = new MeasureResource.IfcBoolean((Ifc4.MeasureResource.IfcBoolean)value);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure) 
				{
					TranslationalStiffnessByLengthX = new MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure((Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure)value);
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBoundaryEdgeCondition), 3)]
		IIfcModulusOfTranslationalSubgradeReactionSelect IIfcBoundaryEdgeCondition.TranslationalStiffnessByLengthY 
		{ 
			get
			{
				if (TranslationalStiffnessByLengthY == null) return null;
				if (TranslationalStiffnessByLengthY is MeasureResource.IfcBoolean) 
					return new Ifc4.MeasureResource.IfcBoolean((MeasureResource.IfcBoolean)TranslationalStiffnessByLengthY);
				if (TranslationalStiffnessByLengthY is MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure((MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure)TranslationalStiffnessByLengthY);
				return null;
			} 
			set
			{
				if (value == null)
				{
					TranslationalStiffnessByLengthY = null;
					return;
				}	
				if (value is Ifc4.MeasureResource.IfcBoolean) 
				{
					TranslationalStiffnessByLengthY = new MeasureResource.IfcBoolean((Ifc4.MeasureResource.IfcBoolean)value);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure) 
				{
					TranslationalStiffnessByLengthY = new MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure((Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure)value);
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBoundaryEdgeCondition), 4)]
		IIfcModulusOfTranslationalSubgradeReactionSelect IIfcBoundaryEdgeCondition.TranslationalStiffnessByLengthZ 
		{ 
			get
			{
				if (TranslationalStiffnessByLengthZ == null) return null;
				if (TranslationalStiffnessByLengthZ is MeasureResource.IfcBoolean) 
					return new Ifc4.MeasureResource.IfcBoolean((MeasureResource.IfcBoolean)TranslationalStiffnessByLengthZ);
				if (TranslationalStiffnessByLengthZ is MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure((MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure)TranslationalStiffnessByLengthZ);
				return null;
			} 
			set
			{
				if (value == null)
				{
					TranslationalStiffnessByLengthZ = null;
					return;
				}	
				if (value is Ifc4.MeasureResource.IfcBoolean) 
				{
					TranslationalStiffnessByLengthZ = new MeasureResource.IfcBoolean((Ifc4.MeasureResource.IfcBoolean)value);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure) 
				{
					TranslationalStiffnessByLengthZ = new MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure((Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure)value);
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBoundaryEdgeCondition), 5)]
		IIfcModulusOfRotationalSubgradeReactionSelect IIfcBoundaryEdgeCondition.RotationalStiffnessByLengthX 
		{ 
			get
			{
				if (RotationalStiffnessByLengthX == null) return null;
				if (RotationalStiffnessByLengthX is MeasureResource.IfcBoolean) 
					return new Ifc4.MeasureResource.IfcBoolean((MeasureResource.IfcBoolean)RotationalStiffnessByLengthX);
				if (RotationalStiffnessByLengthX is MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure((MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure)RotationalStiffnessByLengthX);
				return null;
			} 
			set
			{
				if (value == null)
				{
					RotationalStiffnessByLengthX = null;
					return;
				}	
				if (value is Ifc4.MeasureResource.IfcBoolean) 
				{
					RotationalStiffnessByLengthX = new MeasureResource.IfcBoolean((Ifc4.MeasureResource.IfcBoolean)value);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure) 
				{
					RotationalStiffnessByLengthX = new MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure((Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure)value);
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBoundaryEdgeCondition), 6)]
		IIfcModulusOfRotationalSubgradeReactionSelect IIfcBoundaryEdgeCondition.RotationalStiffnessByLengthY 
		{ 
			get
			{
				if (RotationalStiffnessByLengthY == null) return null;
				if (RotationalStiffnessByLengthY is MeasureResource.IfcBoolean) 
					return new Ifc4.MeasureResource.IfcBoolean((MeasureResource.IfcBoolean)RotationalStiffnessByLengthY);
				if (RotationalStiffnessByLengthY is MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure((MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure)RotationalStiffnessByLengthY);
				return null;
			} 
			set
			{
				if (value == null)
				{
					RotationalStiffnessByLengthY = null;
					return;
				}	
				if (value is Ifc4.MeasureResource.IfcBoolean) 
				{
					RotationalStiffnessByLengthY = new MeasureResource.IfcBoolean((Ifc4.MeasureResource.IfcBoolean)value);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure) 
				{
					RotationalStiffnessByLengthY = new MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure((Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure)value);
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBoundaryEdgeCondition), 7)]
		IIfcModulusOfRotationalSubgradeReactionSelect IIfcBoundaryEdgeCondition.RotationalStiffnessByLengthZ 
		{ 
			get
			{
				if (RotationalStiffnessByLengthZ == null) return null;
				if (RotationalStiffnessByLengthZ is MeasureResource.IfcBoolean) 
					return new Ifc4.MeasureResource.IfcBoolean((MeasureResource.IfcBoolean)RotationalStiffnessByLengthZ);
				if (RotationalStiffnessByLengthZ is MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure) 
					return new Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure((MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure)RotationalStiffnessByLengthZ);
				return null;
			} 
			set
			{
				if (value == null)
				{
					RotationalStiffnessByLengthZ = null;
					return;
				}	
				if (value is Ifc4.MeasureResource.IfcBoolean) 
				{
					RotationalStiffnessByLengthZ = new MeasureResource.IfcBoolean((Ifc4.MeasureResource.IfcBoolean)value);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure) 
				{
					RotationalStiffnessByLengthZ = new MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure((Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure)value);
					return;
				}
				
			}
		}
	//## Custom code
	//##
	}
}