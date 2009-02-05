// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace CBinding {
    
    
    public partial class OutputOptionsPanel {
        
        private Gtk.VBox vbox2;
        
        private Gtk.Table table1;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Entry outputPathTextEntry;
        
        private Gtk.Button browseButton;
        
        private Gtk.Label label1;
        
        private Gtk.Label label2;
        
        private Gtk.Label label3;
        
        private Gtk.Label label4;
        
        private Gtk.Entry outputNameTextEntry;
        
        private Gtk.Entry parametersTextEntry;
        
        private Gtk.CheckButton externalConsoleCheckbox;
        
        private Gtk.CheckButton pauseCheckbox;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget CBinding.OutputOptionsPanel
            Stetic.BinContainer.Attach(this);
            this.Name = "CBinding.OutputOptionsPanel";
            // Container child CBinding.OutputOptionsPanel.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            this.vbox2.BorderWidth = ((uint)(3));
            // Container child vbox2.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(4)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            this.table1.BorderWidth = ((uint)(3));
            // Container child table1.Gtk.Table+TableChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.outputPathTextEntry = new Gtk.Entry();
            this.outputPathTextEntry.CanFocus = true;
            this.outputPathTextEntry.Name = "outputPathTextEntry";
            this.outputPathTextEntry.IsEditable = true;
            this.outputPathTextEntry.InvisibleChar = '●';
            this.hbox1.Add(this.outputPathTextEntry);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox1[this.outputPathTextEntry]));
            w1.Position = 0;
            // Container child hbox1.Gtk.Box+BoxChild
            this.browseButton = new Gtk.Button();
            this.browseButton.CanFocus = true;
            this.browseButton.Name = "browseButton";
            this.browseButton.UseUnderline = true;
            this.browseButton.Label = Mono.Unix.Catalog.GetString("_Browse");
            this.hbox1.Add(this.browseButton);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.browseButton]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            this.table1.Add(this.hbox1);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table1[this.hbox1]));
            w3.TopAttach = ((uint)(2));
            w3.BottomAttach = ((uint)(3));
            w3.LeftAttach = ((uint)(1));
            w3.RightAttach = ((uint)(2));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("<b>Output</b>");
            this.label1.UseMarkup = true;
            this.table1.Add(this.label1);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.label1]));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xalign = 0F;
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Output Name:");
            this.table1.Add(this.label2);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.label2]));
            w5.TopAttach = ((uint)(1));
            w5.BottomAttach = ((uint)(2));
            w5.XPadding = ((uint)(15));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 0F;
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Output Path:");
            this.table1.Add(this.label3);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table1[this.label3]));
            w6.TopAttach = ((uint)(2));
            w6.BottomAttach = ((uint)(3));
            w6.XPadding = ((uint)(15));
            w6.XOptions = ((Gtk.AttachOptions)(4));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.Xalign = 0F;
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("Parameters:");
            this.table1.Add(this.label4);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table1[this.label4]));
            w7.TopAttach = ((uint)(3));
            w7.BottomAttach = ((uint)(4));
            w7.XPadding = ((uint)(15));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.outputNameTextEntry = new Gtk.Entry();
            this.outputNameTextEntry.CanFocus = true;
            this.outputNameTextEntry.Name = "outputNameTextEntry";
            this.outputNameTextEntry.IsEditable = true;
            this.outputNameTextEntry.InvisibleChar = '●';
            this.table1.Add(this.outputNameTextEntry);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table1[this.outputNameTextEntry]));
            w8.TopAttach = ((uint)(1));
            w8.BottomAttach = ((uint)(2));
            w8.LeftAttach = ((uint)(1));
            w8.RightAttach = ((uint)(2));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.parametersTextEntry = new Gtk.Entry();
            this.parametersTextEntry.CanFocus = true;
            this.parametersTextEntry.Name = "parametersTextEntry";
            this.parametersTextEntry.IsEditable = true;
            this.parametersTextEntry.InvisibleChar = '●';
            this.table1.Add(this.parametersTextEntry);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table1[this.parametersTextEntry]));
            w9.TopAttach = ((uint)(3));
            w9.BottomAttach = ((uint)(4));
            w9.LeftAttach = ((uint)(1));
            w9.RightAttach = ((uint)(2));
            w9.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox2.Add(this.table1);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox2[this.table1]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.externalConsoleCheckbox = new Gtk.CheckButton();
            this.externalConsoleCheckbox.CanFocus = true;
            this.externalConsoleCheckbox.Name = "externalConsoleCheckbox";
            this.externalConsoleCheckbox.Label = Mono.Unix.Catalog.GetString("Run on e_xternal console");
            this.externalConsoleCheckbox.Active = true;
            this.externalConsoleCheckbox.DrawIndicator = true;
            this.externalConsoleCheckbox.UseUnderline = true;
            this.vbox2.Add(this.externalConsoleCheckbox);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.vbox2[this.externalConsoleCheckbox]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.pauseCheckbox = new Gtk.CheckButton();
            this.pauseCheckbox.Sensitive = false;
            this.pauseCheckbox.CanFocus = true;
            this.pauseCheckbox.Name = "pauseCheckbox";
            this.pauseCheckbox.Label = Mono.Unix.Catalog.GetString("Pause _console output");
            this.pauseCheckbox.DrawIndicator = true;
            this.pauseCheckbox.UseUnderline = true;
            this.vbox2.Add(this.pauseCheckbox);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox2[this.pauseCheckbox]));
            w12.Position = 2;
            w12.Expand = false;
            w12.Fill = false;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
            this.browseButton.Clicked += new System.EventHandler(this.OnBrowseButtonClick);
            this.externalConsoleCheckbox.Clicked += new System.EventHandler(this.OnExternalConsoleCheckboxClicked);
        }
    }
}
