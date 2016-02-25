<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Xamillionaire.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <script src="/Scripts/jquery-1.10.2.js"></script>
     <script src="/Scripts/bootstrap.js"></script>
    <script src="/Scripts/jquery.signalR-2.2.0.js"></script>
    <script src="/SignalR/hubs"></script>
    <script src="/Scripts/bugfixes.js"></script>

    <link rel="stylesheet" type="text/css" href="/Content/bootstrap.css"/>
    <link rel="stylesheet" type="text/css" href="/Content/Global.css"/>
    <link rel="stylesheet" type="text/css" href="/Content/bugfixes.css"/>


    <script type="text/javascript">
        $(function () {
        //Set the hubs URL for the connection
            //$.connection.hub.url = "http://localhost:52376/signalr"; // Dev
            $.connection.hub.url = "http://xamillionaire.azurewebsites.net/signalr"; //Prod
            
            // Declare a proxy to reference the hub.
            var chat = $.connection.myHub;
            
            // Create a function that the hub can call to broadcast messages.
            chat.client.ShowVote = function (ans) {
                if (ans.Platform == "WatchKit")
                {
                    ResetWatchKitAns();
                    if (ans.IsTrue)
                    {
                        $("#WatchKitYes").show();
                    }
                    else
                    {
                        $("#WatchKitNo").show();
                    }
                }
                else if (ans.Platform == "AndroidWear")
                {
                    ResetAndroidWearAns();
                    if (ans.IsTrue)
                    {
                        $("#WearYes").show();
                    }
                    else
                    {
                        $("#WearNo").show();
                    }
                }
            };

            $.connection.hub.start()
        });

        var questionIndex = 0;
        var questions = ["Does Xamarin Support Watch OS 2?", "Is the Android logo green?"];
        function ResetQuestion()
        {
            ResetAnswers();
            if (questions.length == questionIndex) {
                questionIndex = 0;
            }
            var selectedQuestion = questions[questionIndex];
            $("#Question").html(selectedQuestion);
            $("#LeftAns").html("A: Yes");
            $("#RightAns").html("B: No");
            questionIndex++;
        }

        function ResetAnswers() {
            $("#WearYes").hide();
            $("#WearNo").hide();
            $("#WatchKitYes").hide();
            $("#WatchKitNo").hide();
        }

        function ResetWatchKitAns() {
            $("#WatchKitYes").hide();
            $("#WatchKitNo").hide();
        }

        function ResetAndroidWearAns() {
            $("#WearYes").hide();
            $("#WearNo").hide();
        }

    </script>
</head>
<body>
   <div class="site-wrapper">
      <div class="site-wrapper-inner" style="background-image: url('/Images/background.jpg')">
               <div class="clearfix">
            <center>
            <div onclick="ResetQuestion()" style="background-image:url('/Images/xamillionaire_logo.png'); height: 200px; width:200px;"></div>
            </center>
            </div>
             <div class="clearfix" style="padding-top:20px;">
             <center>
                 <div class="answerImg" style="max-width:700px; height:68px; background-image: url('/Images/question_large.png');">
                     <span id="Question" class="answerText">Where is the worlds steepest road?</span>
                 </div>
             </center>
            </div>
           <div class="clearfix" style="padding-top:20px;">
                   <div style="height: 67px; width: 285px; background-image: url('/Images/ans_left.png'); display: inline-block;" class="answerImg">
                       <span id="LeftAns" class="answerText" style="margin-left:50px;">A: Yes</span>
                   </div>
                   <div style="height: 67px; width: 285px; background-image: url('/Images/ans_right.png'); display: inline-block;" class="answerImg">
                       <span id="RightAns" style="margin-left:-50px;" class="answerText">B: No</span>
                   </div>
           </div>
        <div class="cover-container">
                <div class="masthead clearfix">
            <div class="inner">
            </div>
          </div>

          <div class="inner cover">
            <div class="row" style="padding-top:60px;">
              <div class="col-xs-6">
                  <div class="answerImg" style="height:250px; width: 162px; float:right; background-image: url('/Images/Apple_Watch.png')">
                      <center>
                       <div id="WatchKitNo" class="circle" style="display:none; background-color:red;"><span class="answerText" style="color:white; font-size:16pt; padding-top:15px;">No</span></div>
                      <div id="WatchKitYes" class="circle" style="display:none; background-color:#049604;"><span class="answerText" style="color:white; font-size:16pt; padding-top:15px;">Yes</span></div>
                       </center>
                  </div>
              </div>
              <div class="col-xs-6">
                  <div class="answerImg" style="height:250px; width: 162px; float:left; background-image: url('/Images/android_watch.png')">
                      <center>
                      <div id="WearNo" class="circle" style="display:none; background-color:red;"><span class="answerText" style="color:white; font-size:16pt; padding-top:15px;">No</span></div>
                      <div id="WearYes" class="circle" style="display:none; background-color:#049604;"><span class="answerText" style="color:white; font-size:16pt; padding-top:15px;">Yes</span></div>
                      </center>
                  </div>
              </div>
            </div>
          </div>

          <div class="mastfoot">
            <div class="inner">
              <p>#aklxamarin meetup group</p>
            </div>
          </div>

        </div>

      </div>

    </div>
</body>
</html>
