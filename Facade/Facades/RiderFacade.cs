using Facade.Model;

namespace Facade.Facades
{
    public class RiderFacade
    {
        private TextEditor _textEditor;
        private Compiler _compiler;
        private CLR _clr;

        public RiderFacade(TextEditor textEditor, Compiler compiler, CLR clr)
        {
            _textEditor = textEditor;
            _compiler = compiler;
            _clr = clr;
        }

        public void Start()
        {
            _textEditor.CreateCode();
            _textEditor.Save();
            _compiler.Compile();
            _clr.Execute();
        }

        public void Stop()
        {
            _clr.Finish();
        }
    }
}