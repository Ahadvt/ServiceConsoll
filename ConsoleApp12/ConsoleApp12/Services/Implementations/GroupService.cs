
internal class GroupService : IGroupService
{
    Group[] Groups = new Group[0];
    public void Add(string No)
    {
        Array.Resize(ref Groups, Groups.Length + 1);

        Groups[Groups.Length - 1] = new Group { No = No };

    }
}

