namespace Ratio

type Ratio =
  | Ratio of numerator : int * denominator : int
  with
    override this.ToString() =
      let (Ratio (n, d)) = this
      $"{n}/{d}"

    static member (+) (Ratio (an, ad), Ratio (bn, bd)) =
      if ad = bd then
        Ratio (an + bn, ad)
      else
        Ratio (an * bd + bn * ad, ad * bd)
