var trainBack = new BackTraining();
var trainShoulders = new ShouldersTraining();

DoTraining(trainBack);
DoTraining(trainShoulders);

void DoTraining(Training training){
    training.Train();
}