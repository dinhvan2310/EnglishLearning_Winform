using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Components
{
    public class SoundManager
    {


        private SpeechSynthesizer _Synthesizer = new SpeechSynthesizer();

        public bool IsSpeaking = false;

        public void Speak(string sentence)
        {
            IsSpeaking = true;
            _Synthesizer.Speak(sentence);
            IsSpeaking = false;
        }

        public void ChangeVolumn(int volumn)
        {
            _Synthesizer.Volume = volumn;
        }

        public void ChangeVoice(Voice voice)
        {
            string voiceString = "";
            switch (voice)
            {
                case Voice.Male:
                    voiceString = "Microsoft David Desktop";
                    break;
                case Voice.Female:
                    voiceString = "Microsoft Zira Desktop";
                    break;

            }

            _Synthesizer.SelectVoice(voiceString);
        }
    }

    public enum Voice
    {
        Male, Female
    }
}
