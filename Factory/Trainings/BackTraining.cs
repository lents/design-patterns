public class BackTraining : Training
{
    protected override BackExercise DefineExercise()
    {
        return new BackExercise();
    }
}