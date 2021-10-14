/*
 * Created by SharpDevelop.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace csHaiku
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

        #region variables

        //Initialising variables
        string nounInput1 = "";
		string nounInput2 = "";
		string adjectiveInput = "";
		string verbInput = "";

        //TODO: Remove this array, make a new variable called currentWord, equal it to each input in inputChecks() and run the syllableCounter in inputChecks() in each section
		string[] inputtedWords = new string[5];

		string[] pronoun = new string[10] {"I", "you", "we", "they", "she", "he", "time", "God", "happines", "sadness"};
		string[] noun = new string[8] {"hate", "coldness", "heart", "faith", "skin", "flight", "grave", "world"};
		string[] place = new string[8] {"water", "earth", "soil", "clouds", "emptiness", "space", "cavern", "shadows"};
		string[] preposition = new string[8] {"in", "into", "between", "through", "past", "across", "near", "beneath"};
		string[] article = new string[8] {"a", "the", "my", "our", "his", "her", "their", "your"};
		string[] verbAction = new string[8] {"slither", "crawl", "creep", "dive", "stroll", "push", "drift", "paddle"};
		string[] verbNoAction = new string[8] {"gaze", "listen", "stare", "ignore", "weep", "shudder", "fall", "smile"};
		string[] adjective = new string[8] {"cold", "wet", "slow", "torpid", "silent", "harsh", "misty", "senseless"};
		
		string line1 = "";
		string line2 = "";
		string line3 = "";
		
		Random rng = new Random();
		int randomNum = 0;

        #endregion

        //Input validation
        void inputChecks() 
		{
            /// <summary>
            /// When a text field is left empty, 
            /// The variables are just set to a random from the existing arrays
            /// </summary>
            
            //TODO: Check if the inputs have hypons or more than 3 syllables in (if they do, use pre-existing word)

            inputtedWords[1] = nounInput1;
            inputtedWords[2] = nounInput2;
            inputtedWords[3] = adjectiveInput;
            inputtedWords[4] = verbInput;
            
            if (nounInput1 == "") 
			{
				randomNum = rng.Next(0, 8);
				nounInput1 = noun[randomNum];
				inputtedWords[1] = nounInput1;
			}
			if (nounInput2 == "") 
			{
				randomNum = rng.Next(0, 8);
				nounInput2 = noun[randomNum];
				inputtedWords[2] = nounInput2;
			}
			if (adjectiveInput == "") 
			{
				randomNum = rng.Next(0, 8);
				adjectiveInput = adjective[randomNum];
				inputtedWords[3] = adjectiveInput;
			}
			if (verbInput ==  "") 
			{
				randomNum = rng.Next(0, 8);
				verbInput = verbAction[randomNum];
				inputtedWords[4] = verbInput;
			}
		}
		
        //Checking the grammar of the inputted variables
		void grammarChecks() 
		{
            /// <summary>
            /// If the first noun's last character is an "s",
            /// Add an "s" to the verb
            /// Else,
            ///     If the verb already has an "s" on its end,
            ///     Set its end to "ed" because the noun doesn't have "s" at the end
            ///     Else,
            ///     Still add an "s" onto the end of the verb
            /// </summary>
            char[] trimChar = {'s'};
			if (nounInput1.Substring(nounInput1.Length -1, 1) == "s")
			{
				verbInput = verbInput + "s";					
			} else
			{
				//if (rng.Next(0, 4) > 1) 
				//{
					if (verbInput.Substring(verbInput.Length -1, 1) == "s")
					{
						verbInput = verbInput.TrimEnd(trimChar) + "ed";
					} else 
					{
						verbInput = verbInput + "s";
					}
				//}
			}
		}

        void syllableCounter()
        {
        	/// <summary>
        	/// First, the program loops through the algorithm for each word inputted, as shows in the inputtedWords array
        	/// Then each character is checked through in currentword, 
        	/// 	-Each vowel is checked through
        	/// 	-If the current char is not a vowel, do not do anything (other than changing some bools for the algorithm)
        	/// 	-If the current char is a vowel, add 1 to the numberofvowels found
        	/// If a vowel has not been found, set lastWasVowel to false so that the algorithm can continue to repeat
        	/// Just to remove some silent "es" and "e"s, some checking from the end of the word is done so that the vowel "e" can be removed as it is counted as silent
        	/// </summary>
        	for (int i = 1; i < 5; i++) 
        	{
        		char[] vowels = {'a', 'e', 'i', 'o', 'u'};
        		string currentWord = "";
        		currentWord.Equals(inputtedWords[i]);
        		int numVowels = 0;
        		bool lastWasVowel = false;
        		
        		foreach (char wc in currentWord) 
        		{
        			bool foundVowel = false;
        			foreach (char v in vowels) 
        			{
        				if (v == wc && lastWasVowel) 
        				{
        					foundVowel = true;
        					lastWasVowel = true;
        					break;
        				} else if (v == wc && !lastWasVowel) 
        				{
        					numVowels++;
        					foundVowel = true;
        					lastWasVowel = true;
        					break;
        				}
        			}
        			if (!foundVowel) 
        			{
        				lastWasVowel = false;
        			}
        		}
        		
        		//Removing possibility of silent "es"
        		if (currentWord.Length > 2 && currentWord.Substring(currentWord.Length - 2) == "es") 
        		{
        			numVowels--;
        		//Removing possibility of silent "e"
        		} else if (currentWord.Length > 1 && currentWord.Substring(currentWord.Length - 1) == "e") 
        		{
        			numVowels--;
        		}
        		
        		//TODO: Work out if there is enough syllables in the inputted words to be used
        		
        		if (numVowels > 3)
        		{
        			
        		}
        		
        		MessageBox.Show(currentWord + numVowels);
        	}
        }

        /// <summary>
        /// The first line is simple 
        ///     -Add the randomised words from existing arrays to each other
        /// </summary>
        void line1Build()
		{
			randomNum = rng.Next(0, 8);
			line1 = article[randomNum] + " " + adjective[randomNum] + " " + nounInput1 + " " + verbInput;
		}

        /// <summary>
        /// The second line is slightly more complex
        ///     -The first word is a pre-existing preposition
        ///     -The second word is an pre-existing article
        ///     -Third word is the inputted adjective
        ///     -Final word is the inputted noun
        /// </summary>
        void line2Build() 
		{
			randomNum = rng.Next(0, 8);
			line2 = preposition[randomNum];
			
			randomNum = rng.Next(0, 8);
			line2 = line2 + " " + article[randomNum] + " " + adjectiveInput;
			
			randomNum = rng.Next(0, 8);
			line2 = line2 + " " + nounInput2 + ", ";
		}

        /// <summary>
        /// Third line is FAR more complex
        ///     If the pre-existing ajective (randomly generated) ends with a "y"
        ///     Add an "ily" to the end of it
        ///     Else,
        ///     Add an "ly"
        ///     
        ///     Ranomising the . and , for the second word end
        ///     
        ///     Adding a pre-existing pronoun to the third line
        ///     If one of the pronouns is in the second subcatergory
        /// 	Add an "s" onto the end
        /// 
        /// 	If one of the pre-existing verbs is in the second subcatergory
        /// 	Add it to the line
        /// 	Else,
        /// 	If there is an "s" on the end of the word
        /// 		Add the word to the line
        /// 		Else
        /// 		If there is no "s" on the end of the word
        /// 		Add an "s" onto the end, and then add it
        /// </summary>
        void line3Build() 
		{
        	//FIRST WORD
			randomNum = rng.Next(0, 8);
			if (adjective[randomNum].Substring(adjective[randomNum].Length -1, 1) == "y")
			{
				char[] trimChars = {'y'};
				line3 = (adjective[randomNum].TrimEnd(trimChars) + "ily");
			} else 
			{
				line3 = (adjective[randomNum].TrimEnd() + "ly");
			}
			
			//COMMA OR FULL STOP SWITCHER
			if (rng.Next(0, 3) > 1)
			{
				line3 = line3 + ".";
			} else 
			{
				line3 = line3 + ",";
			}
			
			//SECOND WORD
			randomNum = rng.Next(0, 10);
			line3 = line3 + " " + pronoun[randomNum];
			if (randomNum > 6)
			{
				line3 = line3 + "s";
			}
			
			//THIRD WORD
			randomNum = rng.Next(0, 8);
			if (randomNum > 3) 
			{
				//TODO: Find a way to incoportate if the pronoun is in second subcategory (aka God+), make sure the verbnoaction does have an "s" added to it, if not then dont
				line3 = line3 + " " + verbNoAction[randomNum];
			} else 
			{
				if (verbNoAction[randomNum].Substring(verbNoAction[randomNum].Length - 1) == "s") 
				{
					MessageBox.Show("Last word does have s at the end");
					line3 = line3 + " " + verbNoAction[randomNum];
				} else 
				{
					char[] trimChar2 = {'s'};
					line3 = line3 + " " + verbNoAction[randomNum].TrimEnd(trimChar2);
				}
			}
        }
		
		void BtnSubmitClick(object sender, EventArgs e)
		{
			line1 = "";
			line2 = "";
			line3 = "";
			
			nounInput1 = txtNoun1.Text;
			nounInput2 = txtNoun2.Text;
			adjectiveInput = txtAdjective.Text;
			verbInput = txtVerb.Text;
		
			inputChecks();
			grammarChecks();
			//syllableCounter();
			line1Build();
			line2Build();
			line3Build();
			
			lblOutput1.Text = line1;
			lblOutput2.Text = line2;
			lblOutput3.Text = line3;
		}
		
		void BtnExampleClick(object sender, EventArgs e)
		{
			txtNoun1.Text = "table";
			txtNoun2.Text = "chair";
			txtVerb.Text = "sit";
			txtAdjective.Text = "big";
		}
	}
}
