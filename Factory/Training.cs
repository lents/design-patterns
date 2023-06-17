public abstract class Training
{
    private List<Exercise> exercises = new List<Exercise>();

    public Training()
    {
        exercises.Add(DefineExercise());
        exercises.Add(DefineExercise());
        exercises.Add(DefineExercise());
    }

    public void Train()
    {
        for (int i = 0; i < exercises.Count; i++)
        {
            Console.WriteLine("Do next exercise:");
            exercises[i].Do();
        }
    }

    protected abstract Exercise DefineExercise();
}