using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Central_Dispatch_Prototype.Models
{
    public class Preferences
    {
        public Payment Payout { get; set; }
        public Rating Rating { get; set; }
        public Location Starting { get; set; }
        public Location Endpoint { get; set; }

        public Part top { get; set; }
        public Part second { get; set; }
        public Part third { get; set; }
        public Part last { get; set; }

        public List<Result> results = new List<Result>();

        public String returnResults (Preferences preferences)
        {
            int resultsCount = 0;
            StringBuilder htmlWriter = new StringBuilder();
            if(preferences.top == Part.Start)
            {
                if(preferences.second == Part.Destination)
                {
                    if (preferences.third == Part.Payout)
                    {
                        //preferences.last == Part.Rating
                            foreach (var result in preferences.results)
                            {
                                if (resultsCount == 10)
                                {
                                    break;
                                }
                                if ((result.start == preferences.Starting) && (result.destination == preferences.Endpoint) && (result.payout == preferences.Payout) && (result.rating == preferences.Rating))
                                {
                                //show result
                                    if (result.Displaying == false)
                                    {
                                        htmlWriter.Append(""+result.Appearance);
                                        result.Displaying = true;
                                        resultsCount++;
                                    }
                                }
                            }
                            foreach (var result in preferences.results)
                            {
                                if (resultsCount == 10)
                                {
                                    break;
                                }
                                if ((result.start == preferences.Starting) && (result.destination == preferences.Endpoint) && (result.payout == preferences.Payout))
                                {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append( result.Appearance );
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                            }
                            foreach (var result in preferences.results)
                            {
                                if (resultsCount == 10)
                                {
                                    break;
                                }
                                if ((result.start == preferences.Starting) && (result.destination == preferences.Endpoint))
                                {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append( result.Appearance );
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                            }
                            foreach (var result in preferences.results)
                            {
                                if (resultsCount == 10)
                                {
                                    break;
                                }
                                if (result.start == preferences.Starting)
                                {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append( result.Appearance );
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                            }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                    else //preferences.third == Part.Rating
                    {
                        //preferences.last == Part.Payout
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.destination == preferences.Endpoint) && (result.rating == preferences.Rating) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.destination == preferences.Endpoint) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.start == preferences.Starting)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                } else if(preferences.second == Part.Payout)
                {
                    if(preferences.third == Part.Destination)
                    {
                        //preferences.last == Part.Rating
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.payout == preferences.Payout) && (result.destination == preferences.Endpoint) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.payout == preferences.Payout) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.start == preferences.Starting)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                    else //preferences.third == Part.Rating
                    {
                        //preferences.last == Part.Destination
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.payout == preferences.Payout) && (result.rating == preferences.Rating) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.payout == preferences.Payout) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.start == preferences.Starting)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                } else //preferences.second == Part.Rating
                {
                    if(preferences.third == Part.Destination)
                    {
                        //preferences.last == Part.Payout
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.rating == preferences.Rating) && (result.destination == preferences.Endpoint) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.rating == preferences.Rating) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.start == preferences.Starting)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                    else //preferences.third == Part.Payout
                    {
                        //prefrencecs.last == Part.Destination
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.rating == preferences.Rating) && (result.payout == preferences.Payout) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.rating == preferences.Rating) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.start == preferences.Starting) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.start == preferences.Starting)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                }
            } else if (preferences.top == Part.Destination)
            {
                if (preferences.second == Part.Start)
                {
                    if (preferences.third == Part.Payout)
                    {
                        //preferences.last == Part.Rating
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.start == preferences.Starting) && (result.payout == preferences.Payout) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.start == preferences.Starting) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.destination == preferences.Endpoint)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                    else //preferences.third == Part.Rating
                    {
                        //preferences.last == Part.Payout
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.start == preferences.Starting) && (result.rating == preferences.Rating) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.start == preferences.Starting) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.destination == preferences.Endpoint)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                }
                else if (preferences.second == Part.Payout)
                {
                    if (preferences.third == Part.Start)
                    {
                        //preferences.last == Part.Rating
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.payout == preferences.Payout) && (result.start == preferences.Starting) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.payout == preferences.Payout) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.destination == preferences.Endpoint)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                    else //preferences.third == Part.Rating
                    {
                        //preferences.last == Part.Start
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.payout == preferences.Payout) && (result.rating == preferences.Rating) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.payout == preferences.Payout) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.destination == preferences.Endpoint)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                }
                else //preferences.second == Part.Rating
                {
                    if (preferences.third == Part.Start)
                    {
                        //preferences.last == Part.Payout
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.rating == preferences.Rating) && (result.start == preferences.Starting) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.rating == preferences.Rating) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.destination == preferences.Endpoint)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                    else //preferences.third == Part.Payout
                    {
                        //prefrencecs.last == Part.Start
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.rating == preferences.Rating) && (result.payout == preferences.Payout) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.rating == preferences.Rating) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.destination == preferences.Endpoint) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.destination == preferences.Endpoint)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                }
            } else if (preferences.top == Part.Payout)
            {
                if (preferences.second == Part.Destination)
                {
                    if (preferences.third == Part.Start)
                    {
                        //preferences.last == Part.Rating
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.destination == preferences.Endpoint) && (result.start == preferences.Starting) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.destination == preferences.Endpoint) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.payout == preferences.Payout)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                    else //preferences.third == Part.Rating
                    {
                        //preferences.last == Part.Start
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.destination == preferences.Endpoint) && (result.rating == preferences.Rating) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.destination == preferences.Endpoint) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.payout == preferences.Payout)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                }
                else if (preferences.second == Part.Start)
                {
                    if (preferences.third == Part.Destination)
                    {
                        //preferences.last == Part.Rating
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.start == preferences.Starting) && (result.destination == preferences.Endpoint) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.start == preferences.Starting) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.payout == preferences.Payout)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                    else //preferences.third == Part.Rating
                    {
                        //preferences.last == Part.Destination
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.start == preferences.Starting) && (result.rating == preferences.Rating) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.start == preferences.Starting) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.payout == preferences.Payout)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                }
                else //preferences.second == Part.Rating
                {
                    if (preferences.third == Part.Destination)
                    {
                        //preferences.last == Part.Start
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.rating == preferences.Rating) && (result.destination == preferences.Endpoint) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.rating == preferences.Rating) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.payout == preferences.Payout)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                    else //preferences.third == Part.Start
                    {
                        //prefrencecs.last == Part.Destination
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.rating == preferences.Rating) && (result.start == preferences.Starting) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.rating == preferences.Rating) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.payout == preferences.Payout) && (result.rating == preferences.Rating))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.payout == preferences.Payout)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                }
            } else //preferences.top == Part.Rating
            {
                if (preferences.second == Part.Destination)
                {
                    if (preferences.third == Part.Payout)
                    {
                        //preferences.last == Part.Start
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.destination == preferences.Endpoint) && (result.payout == preferences.Payout) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.destination == preferences.Endpoint) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.rating == preferences.Rating)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                    else //preferences.third == Part.Start
                    {
                        //preferences.last == Part.Payout
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.destination == preferences.Endpoint) && (result.start == preferences.Starting) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.destination == preferences.Endpoint) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.rating == preferences.Rating)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                }
                else if (preferences.second == Part.Payout)
                {
                    if (preferences.third == Part.Destination)
                    {
                        //preferences.last == Part.Start
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.payout == preferences.Payout) && (result.destination == preferences.Endpoint) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.payout == preferences.Payout) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.rating == preferences.Rating)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                    else //preferences.third == Part.Start
                    {
                        //preferences.last == Part.Destination
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.payout == preferences.Payout) && (result.start == preferences.Starting) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.payout == preferences.Payout) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.rating == preferences.Rating)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                }
                else //preferences.second == Part.Start
                {
                    if (preferences.third == Part.Destination)
                    {
                        //preferences.last == Part.Payout
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.start == preferences.Starting) && (result.destination == preferences.Endpoint) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.start == preferences.Starting) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.rating == preferences.Rating)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                    else //preferences.third == Part.Payout
                    {
                        //prefrencecs.last == Part.Destination
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.start == preferences.Starting) && (result.payout == preferences.Payout) && (result.destination == preferences.Endpoint))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append("" + result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.start == preferences.Starting) && (result.payout == preferences.Payout))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if ((result.rating == preferences.Rating) && (result.start == preferences.Starting))
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        foreach (var result in preferences.results)
                        {
                            if (resultsCount == 10)
                            {
                                break;
                            }
                            if (result.rating == preferences.Rating)
                            {
                                //show result
                                if (result.Displaying == false)
                                {
                                    htmlWriter.Append(result.Appearance);
                                    result.Displaying = true;
                                    resultsCount++;
                                }
                            }
                        }
                        if (resultsCount == 0)
                        {
                            //show no results found
                            htmlWriter.Append("<p> No results found. <p>");
                        }
                    }
                }
            }
            return htmlWriter.ToString();
        }
        
        public void populateResults(Preferences preferences){
            //fill list of Results w/ refs to Brad's card images
            //Result constructor takes in attributes + img file path & builds a line of HTML

            preferences.results.Add(new Result(@"/Content/SearchResults/56_Browse_Card_P_A_250_7079.png", Location.Phoenix, Location.Atlanta, Payment.opt1, Rating.opt5));
            preferences.results.Add(new Result(@"/Content/SearchResults/57_Browse_Card_P_A_250_8089.png", Location.Phoenix, Location.Atlanta, Payment.opt1, Rating.opt6));
            preferences.results.Add(new Result(@"/Content/SearchResults/58_Browse_Card_P_A_250_90100.png", Location.Phoenix, Location.Atlanta, Payment.opt1, Rating.opt7));

            preferences.results.Add(new Result(@"/Content/SearchResults/59_Browse_Card_P_A_500_7079.png", Location.Phoenix, Location.Atlanta, Payment.opt2, Rating.opt5));
            preferences.results.Add(new Result(@"/Content/SearchResults/60_Browse_Card_P_A_500_8089.png", Location.Phoenix, Location.Atlanta, Payment.opt2, Rating.opt6));
            preferences.results.Add(new Result(@"/Content/SearchResults/61_Browse_Card_P_A_500_90100.png", Location.Phoenix, Location.Atlanta, Payment.opt2, Rating.opt7));

            preferences.results.Add(new Result(@"/Content/SearchResults/62_Browse_Card_P_A_750_7079.png", Location.Phoenix, Location.Atlanta, Payment.opt3, Rating.opt5));
            preferences.results.Add(new Result(@"/Content/SearchResults/63_Browse_Card_P_A_750_8089.png", Location.Phoenix, Location.Atlanta, Payment.opt3, Rating.opt6));
            preferences.results.Add(new Result(@"/Content/SearchResults/64_Browse_Card_P_A_750_90100.png", Location.Phoenix, Location.Atlanta, Payment.opt3, Rating.opt7));

            preferences.results.Add(new Result(@"/Content/SearchResults/65_Browse_Card_P_C_250_7079.png", Location.Phoenix, Location.Chicago, Payment.opt1, Rating.opt5));
            preferences.results.Add(new Result(@"/Content/SearchResults/66_Browse_Card_P_C_250_8089.png", Location.Phoenix, Location.Chicago, Payment.opt1, Rating.opt6));
            preferences.results.Add(new Result(@"/Content/SearchResults/67_Browse_Card_P_C_250_90100.png", Location.Phoenix, Location.Chicago, Payment.opt1, Rating.opt7));

            preferences.results.Add(new Result(@"/Content/SearchResults/68_Browse_Card_P_C_500_7079.png", Location.Phoenix, Location.Chicago, Payment.opt2, Rating.opt5));
            preferences.results.Add(new Result(@"/Content/SearchResults/69_Browse_Card_P_C_500_8089.png", Location.Phoenix, Location.Chicago, Payment.opt2, Rating.opt6));
            preferences.results.Add(new Result(@"/Content/SearchResults/70_Browse_Card_P_C_500_90100.png", Location.Phoenix, Location.Chicago, Payment.opt2, Rating.opt7));

            preferences.results.Add(new Result(@"/Content/SearchResults/71_Browse_Card_P_C_750_7079.png", Location.Phoenix, Location.Chicago, Payment.opt3, Rating.opt5));
            preferences.results.Add(new Result(@"/Content/SearchResults/72_Browse_Card_P_C_750_8089.png", Location.Phoenix, Location.Chicago, Payment.opt3, Rating.opt6));
            preferences.results.Add(new Result(@"/Content/SearchResults/73_Browse_Card_P_C_750_90100.png", Location.Phoenix, Location.Chicago, Payment.opt3, Rating.opt7));

            preferences.results.Add(new Result(@"/Content/SearchResults/74_Browse_Card_P_S_250_7079.png", Location.Phoenix, Location.Seattle, Payment.opt1, Rating.opt5));
            preferences.results.Add(new Result(@"/Content/SearchResults/75_Browse_Card_P_S_250_8089.png", Location.Phoenix, Location.Seattle, Payment.opt1, Rating.opt6));
            preferences.results.Add(new Result(@"/Content/SearchResults/76_Browse_Card_P_S_250_90100.png", Location.Phoenix, Location.Seattle, Payment.opt1, Rating.opt7));

            preferences.results.Add(new Result(@"/Content/SearchResults/77_Browse_Card_P_S_500_7079.png", Location.Phoenix, Location.Seattle, Payment.opt2, Rating.opt5));
            preferences.results.Add(new Result(@"/Content/SearchResults/78_Browse_Card_P_S_500_8089.png", Location.Phoenix, Location.Seattle, Payment.opt2, Rating.opt6));
            preferences.results.Add(new Result(@"/Content/SearchResults/79_Browse_Card_P_S_500_90100.png", Location.Phoenix, Location.Seattle, Payment.opt2, Rating.opt7));

            preferences.results.Add(new Result(@"/Content/SearchResults/80_Browse_Card_P_S_750_7079.png", Location.Phoenix, Location.Seattle, Payment.opt3, Rating.opt5));
            preferences.results.Add(new Result(@"/Content/SearchResults/81_Browse_Card_P_S_750_8089.png", Location.Phoenix, Location.Seattle, Payment.opt3, Rating.opt6));
            preferences.results.Add(new Result(@"/Content/SearchResults/82_Browse_Card_P_S_750_90100.png", Location.Phoenix, Location.Seattle, Payment.opt3, Rating.opt7));
        }
    }
}

    public enum Part
    {
        Rating,
        Start,
        Destination,
        Payout
    }

    public enum Location
    {
        Atlanta,
        Phoenix,
        Seattle,
        Chicago
    }

    public enum Payment
    {
        [Display(Name = "$250")]
        opt1 =250,
        [Display(Name = "$500")]
        opt2 =500,
        [Display(Name = "$750")]
        opt3 =750
    }

    public enum Rating
    {
        [Display(Name = "70-79%")]
        opt5 = 70,
        [Display(Name = "80-89%")]
        opt6 = 80,
        [Display(Name = "90-100%")]
        opt7 = 90
    }
