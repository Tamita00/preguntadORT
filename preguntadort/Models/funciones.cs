public class funciones{

static int Rndm(int desde, int hasta)
{
	Random num= new Random ();
	return num.Next (desde, hasta + 1);
}
}