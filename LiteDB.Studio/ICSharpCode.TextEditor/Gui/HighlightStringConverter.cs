using ICSharpCode.TextEditor.Document;
using System;
using System.ComponentModel;

namespace ICSharpCode.TextEditor
{

    public class HighlightStringConverter : StringConverter {
        public override Boolean GetStandardValuesSupported(ITypeDescriptorContext context) {
            return true;
        }

        public override Boolean GetStandardValuesExclusive(ITypeDescriptorContext context) {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) {
            return new StandardValuesCollection(HighlightingManager.Manager.HighlightingDefinitions.Keys);
        }
    }
}
