#pragma checksum "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DiagramFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbd22b3c5a65f719d864a906634c563cecec49b0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DataImageBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using DataImageBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using DataImageBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DiagramFeatures.razor"
using Syncfusion.Blazor.Diagrams;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DiagramFeatures.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DiagramFeatures.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DiagramFeatures.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DiagramFeatures.razor"
using DiagramShapes = Syncfusion.Blazor.Diagrams.Shapes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DiagramFeatures.razor"
using DiagramSegments = Syncfusion.Blazor.Diagrams.Segments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DiagramFeatures.razor"
using Orientation= Syncfusion.Blazor.Diagrams.Orientation;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/diagram-features")]
    public partial class DiagramFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\Admin\Desktop\dataImage.IO_MachineLearningApp\DataImageProject\DataImageBlazorApp\Pages\DiagramFeatures.razor"
 
    object scrollableArea =new Dictionary<string,object>(){ { "x" , 0 },{ "y" , 0 }, { "width" , 100 }, { "height" , 700 } };
    DiagramConstraints diagramConstraints = 
              DiagramConstraints.Default & DiagramConstraints.PageEditable
          ;
    int connectorCount = 0;
    int portCount = 0;
    // Reference to diagram
    SfDiagram diagram;
    // Defines diagram's nodes collection
    public ObservableCollection<DiagramNode> NodeCollection { get; set; }
    // Defines diagram's connector collection
    public ObservableCollection<DiagramConnector> ConnectorCollection { get; set; }
    // Defines default values for DiagramNode object
    public DiagramNode NodeDefaults { get; set; }
    // Defines default values for DiagramConnector object
    public DiagramConnector ConnectorDefaults { get; set; }
    // Defines interval values for GridLines
    public double[] GridLineIntervals = new double[] {
            1, 9, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75
        };
    // Defines palette's flow-shape collection
    public ObservableCollection<DiagramNode> FlowShapeList { get; set; }
    // Defines palette's connector collection
    public ObservableCollection<DiagramConnector> ConnectorList { get; set; }
    // Defines Symbol info
    public SymbolInfo SymbolInfo { get; set; }
    bool CanFit = true;
    FitModes Mode = FitModes.Width;
    protected override void OnInitialized()
    {
        InitDiagramModel();
        InitPaletteModel();
    }
    private void InitDiagramModel()
    {
        InitDiagramDefaults();
        NodeCollection = new ObservableCollection<DiagramNode>();
        ConnectorCollection = new ObservableCollection<DiagramConnector>();
        CreateNode("node1", 300, 80, FlowShapes.Terminator, "Place Order");
        CreateNode("node2", 300, 160, FlowShapes.Process, "Start Transaction");
        CreateNode("node3", 300, 240, FlowShapes.Process, "Verification");
        CreateNode("node4", 300, 330, FlowShapes.Decision, "Credit card valid?");
        CreateNode("node5", 300, 430, FlowShapes.Decision, "Funds available?");
        CreateNode("node6", 530, 330, FlowShapes.Process, "Enter payment method");
        CreateNode("node7", 300, 530, FlowShapes.Process, "Complete Transaction");
        CreateNode("node8", 110, 530, FlowShapes.Data, "Send e-mail", true);
        CreateNode("node9", 475, 530, FlowShapes.DirectData, "Customer Database", true);
        CreateNode("node10", 300, 630, FlowShapes.Terminator, "Log transaction");
        CreateNode("node11", 480, 630, FlowShapes.Process, "Reconcile the entries");
        Syncfusion.Blazor.Diagrams.DiagramConnectorSegment segment1 = new Syncfusion.Blazor.Diagrams.DiagramConnectorSegment()
        {
            Type = DiagramSegments.Orthogonal,
            Length = 120,
            Direction = Direction.Top
        };
        Syncfusion.Blazor.Diagrams.DiagramConnectorSegment segment2 = new Syncfusion.Blazor.Diagrams.DiagramConnectorSegment()
        {
            Type = DiagramSegments.Orthogonal,
            Length = 100,
            Direction = Direction.Right
        };
        CreateConnector("node1", "node2");
        CreateConnector("node2", "node3");
        CreateConnector("node3", "node4");
        CreateConnector("node4", "node5", "Yes");
        CreateConnector("node4", "node6", "No");
        CreateConnector("node5", "node6", "No", segment2);
        CreateConnector("node5", "node7", "Yes");
        CreateConnector("node6", "node2", default(string), segment1);
        CreateConnector("node7", "node8");
        CreateConnector("node7", "node9");
        CreateConnector("node7", "node10");
        CreateConnector("node10", "node11", default(string), null, true);
    }
    private void InitDiagramDefaults()
    {
        ObservableCollection<DiagramPort> defaultsPorts = new ObservableCollection<DiagramPort>();
        defaultsPorts.Add(CreatePort(0, 0.5));
        defaultsPorts.Add(CreatePort(0.5, 1));
        defaultsPorts.Add(CreatePort(1, 0.5));
        defaultsPorts.Add(CreatePort(0.5, 0));
        NodeDefaults = new DiagramNode()
        {
            Width = 145,
            Height = 60,
            Ports = defaultsPorts,
            Annotations = new ObservableCollection<DiagramNodeAnnotation>() { },
            Style = new NodeShapeStyle() { Fill = "#357BD2", StrokeColor = "white" }
        };
        ConnectorDefaults = new DiagramConnector()
        {
            Type = DiagramSegments.Orthogonal,
            TargetDecorator = new ConnectorTargetDecorator() { Shape = DecoratorShapes.Arrow, Width = 10, Height = 10 }
        };
    }
    private DiagramPort CreatePort(double x, double y)
    {
        return new DiagramPort()
        {
            Id = string.Format("port{0}", ++portCount),
            Shape = PortShapes.Circle,
            Offset = new NodePortOffset() { X = x, Y = y }
        };
    }
    private void CreateNode(string id, double x, double y, FlowShapes shape, string label, bool positionLabel = false)
    {
        DiagramNodeAnnotation annotation = new DiagramNodeAnnotation()
        {
            Content = label,
            Style = new AnnotationStyle()
            {
                Color = "white",
                Fill = "transparent"
            }
        };
        if (positionLabel)
        {
            annotation.Margin = new NodeAnnotationMargin() { Left = 25, Right = 25 };
        };
        DiagramNode diagramNode = new DiagramNode()
        {
            Id = id,
            OffsetX = x,
            OffsetY = y,
            Shape = new DiagramShape() { Type = DiagramShapes.Flow, FlowShape = shape },
            Annotations = new ObservableCollection<DiagramNodeAnnotation>() { annotation }
        };
        NodeCollection.Add(diagramNode);
    }
    private void CreateConnector(string sourceId, string targetId, string label = default(string), Syncfusion.Blazor.Diagrams.DiagramConnectorSegment segment = null, bool isDashLine = false)
    {
        DiagramConnector diagramConnector = new DiagramConnector()
        {
            Id = string.Format("connector{0}", ++connectorCount),
            SourceID = sourceId,
            TargetID = targetId
        };
        if (label != default(string))
        {
            var annotation = new DiagramConnectorAnnotation()
            {
                Content = label,
                Style = new AnnotationStyle() { Fill = "white" }
            };
            diagramConnector.Annotations = new ObservableCollection<DiagramConnectorAnnotation>() { annotation };
        }
        if (segment != null)
        {
            diagramConnector.Segments = new ObservableCollection<Syncfusion.Blazor.Diagrams.DiagramConnectorSegment>() { segment };
        }
        if (isDashLine)
        {
            diagramConnector.Style = new ConnectorShapeStyle() { StrokeDashArray = "2,2" };
        }
        ConnectorCollection.Add(diagramConnector);
    }
    private void InitPaletteModel()
    {
        SymbolInfo = new SymbolInfo() { Fit = true };
        FlowShapeList = new ObservableCollection<DiagramNode>();
        CreatePaletteNode(FlowShapes.Terminator);
        CreatePaletteNode(FlowShapes.Process);
        CreatePaletteNode(FlowShapes.Decision);
        CreatePaletteNode(FlowShapes.Document);
        CreatePaletteNode(FlowShapes.PreDefinedProcess);
        CreatePaletteNode(FlowShapes.PaperTap);
        CreatePaletteNode(FlowShapes.DirectData);
        CreatePaletteNode(FlowShapes.SequentialData);
        CreatePaletteNode(FlowShapes.Sort);
        CreatePaletteNode(FlowShapes.MultiDocument);
        CreatePaletteNode(FlowShapes.Collate);
        CreatePaletteNode(FlowShapes.SummingJunction);
        CreatePaletteNode(FlowShapes.Or);
        CreatePaletteNode(FlowShapes.InternalStorage);
        CreatePaletteNode(FlowShapes.Extract);
        CreatePaletteNode(FlowShapes.ManualOperation);
        CreatePaletteNode(FlowShapes.Merge);
        CreatePaletteNode(FlowShapes.OffPageReference);
        CreatePaletteNode(FlowShapes.SequentialAccessStorage);
        CreatePaletteNode(FlowShapes.Annotation);
        CreatePaletteNode(FlowShapes.Annotation2);
        CreatePaletteNode(FlowShapes.Data);
        CreatePaletteNode(FlowShapes.Card);
        CreatePaletteNode(FlowShapes.Delay);
        ConnectorList = new ObservableCollection<DiagramConnector>();
        CreatePaletteConnector("Link1", DiagramSegments.Orthogonal, DecoratorShapes.Arrow);
        CreatePaletteConnector("Link2", DiagramSegments.Orthogonal, DecoratorShapes.None);
        CreatePaletteConnector("Link3", DiagramSegments.Straight, DecoratorShapes.Arrow);
        CreatePaletteConnector("Link4", DiagramSegments.Straight, DecoratorShapes.None);
        CreatePaletteConnector("Link5", DiagramSegments.Bezier, DecoratorShapes.None);
    }
    private void CreatePaletteNode(FlowShapes flowShape)
    {
        DiagramNode diagramNode = new DiagramNode()
        {
            Id = flowShape.ToString(),
            Shape = new DiagramShape() { Type = DiagramShapes.Flow, FlowShape = flowShape }
        };
        FlowShapeList.Add(diagramNode);
    }
    private void CreatePaletteConnector(string id, DiagramSegments type, DecoratorShapes decoratorShape)
    {
        DiagramConnector diagramConnector = new DiagramConnector()
        {
            Id = id,
            Type = type,
            SourcePoint = new ConnectorSourcePoint() { X = 0, Y = 0 },
            TargetPoint = new ConnectorTargetPoint() { X = 60, Y = 60 },
            Style = new ConnectorShapeStyle() { StrokeWidth = 1 },
            TargetDecorator = new ConnectorTargetDecorator() { Shape = decoratorShape }
        };
        ConnectorList.Add(diagramConnector);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591