﻿namespace DragaliaBaasServer.Models.Vcm;

public record VcmBundle(
    VcmCurrency VirtualCurrencyName,
    VcmMarket Market,
    IEnumerable<VcmBundleItem> Items
)
{
    public static List<VcmBundle> GetEmptyBundlesForMarket(VcmMarket market)
        =>
        [
            new VcmBundle(VcmCurrency.diamond, market, [
                new VcmBundleItem("41ba5c3fdc3d110b", VcmCurrency.diamond, 384, 116,
                    "com.nintendo.zaga.2019.newyearpack1.tier8",
                    7.99, 7.99, "USD", ""),
                new VcmBundleItem("e9061bfede992f8a", VcmCurrency.diamond, 480, 480,
                    "com.nintendo.zaga.2019.newyearpack2.tier10",
                    9.99, 9.99, "USD", ""),
                new VcmBundleItem("89e06eb193d119d4", VcmCurrency.diamond, 1920, 80,
                    "com.nintendo.zaga.2019.newyearpack3.tier40",
                    39.99, 39.99, "USD", ""),
                new VcmBundleItem("12f92c9f52a0de3e", VcmCurrency.diamond, 1920, 80,
                    "com.nintendo.zaga.2019.newyearpack4.tier40",
                    39.99, 39.99, "USD", ""),
                new VcmBundleItem("d77cb79a202e0f9f", VcmCurrency.diamond, 3920, 580,
                    "com.nintendo.zaga.2019.newyearpack5.tier56",
                    79.99, 79.99, "USD", ""),
                new VcmBundleItem("98920d1f253c9e5c", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.2019.newyearpack7.tier25",
                    24.99, 24.99, "USD", ""),
                new VcmBundleItem("44c6467a6b3be0ed", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.20190426pack1.tier25", 24.99,
                    24.99, "USD", ""),
                new VcmBundleItem("b43951cbc52390ea", VcmCurrency.diamond, 192, 8,
                    "com.nintendo.zaga.20190426pack2.tier4", 3.99,
                    3.99, "USD", ""),
                new VcmBundleItem("ff65bea22abdeb0e", VcmCurrency.diamond, 1200, 30,
                    "com.nintendo.zaga.20190731pack1.tier25", 24.99,
                    24.99, "USD", ""),
                new VcmBundleItem("0cc8d59f701730c9", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20190731pack2.tier40", 39.99,
                    39.99, "USD", ""),
                new VcmBundleItem("713b47f1484b9447", VcmCurrency.diamond, 1200, 30,
                    "com.nintendo.zaga.20190813pack1.tier25", 24.99,
                    24.99, "USD", ""),
                new VcmBundleItem("bdc7d47551bb608d", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20190813pack2.tier40", 39.99,
                    39.99, "USD", ""),
                new VcmBundleItem("8d5d654fa5bb8a47", VcmCurrency.diamond, 192, 108,
                    "com.nintendo.zaga.20190927pack1.tier4", 3.99,
                    3.99, "USD", ""),
                new VcmBundleItem("be6275615457d61b", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.20190927pack2.tier25", 24.99,
                    24.99, "USD", ""),
                new VcmBundleItem("902f1fc9c9ed7eb7", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.20190927pack3.tier25", 24.99,
                    24.99, "USD", ""),
                new VcmBundleItem("c7ccc69586abb963", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.20190927pack4.tier25", 24.99,
                    24.99, "USD", ""),
                new VcmBundleItem("24954bbdc0ef581e", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20190927pack5.tier40", 39.99,
                    39.99, "USD", ""),
                new VcmBundleItem("d40bdea5fc36e320", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20190927pack6.tier56", 79.99,
                    79.99, "USD", ""),
                new VcmBundleItem("413af8eea505c008", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20191128pack1.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("59d9758fa6efaa61", VcmCurrency.diamond, 1200, 30,
                    "com.nintendo.zaga.20191128pack2.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("c993b29b2ee07d9c", VcmCurrency.diamond, 1200, 30,
                    "com.nintendo.zaga.20191128pack3.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("e7b49d4f8ce3a519", VcmCurrency.diamond, 384, 116,
                    "com.nintendo.zaga.20191231pack1.tier8", 7.99,
                    7.99, "USD", "", ""),
                new VcmBundleItem("7df074aab3b71ce3", VcmCurrency.diamond, 3920, 580,
                    "com.nintendo.zaga.20191231pack2.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("a8fe1fc14d56956b", VcmCurrency.diamond, 1200, 30,
                    "com.nintendo.zaga.20191231pack3.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("b4543b0caae57867", VcmCurrency.diamond, 1200, 30,
                    "com.nintendo.zaga.20191231pack4.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("f7c6b8ba057c21a3", VcmCurrency.diamond, 480, 480,
                    "com.nintendo.zaga.20191231pack5.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("213194ebea566da5", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20200129pack1.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("06ed3a47174c0cf2", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20200129pack2.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("69a2425d24e7ce32", VcmCurrency.diamond, 192, 108,
                    "com.nintendo.zaga.20200129pack3.tier4", 3.99,
                    3.99, "USD", "", ""),
                new VcmBundleItem("15d8c05001742053", VcmCurrency.diamond, 1200, 30,
                    "com.nintendo.zaga.20200129pack4.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("d412f7eaf691712e", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20200129pack5.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("a281d2788e7d4f0b", VcmCurrency.diamond, 1200, 30,
                    "com.nintendo.zaga.20200129pack6.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("c2cc3fe1cc8f085e", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.20200327pack1.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("18a3307c05ac4e1d", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.20200327pack5.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("11050bf53b314605", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20200327pack6.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("93eb72a919432c7d", VcmCurrency.diamond, 3920, 1780,
                    "com.nintendo.zaga.20200327pack7.tier56",
                    79.99, 79.99, "USD", "", ""),
                new VcmBundleItem("c235990cd3fcb39d", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20200327pack8.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("ffd2b7ffe6a4ab71", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20200430pack1.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("8bcf46779aa09b79", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.20200430pack2.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("881009706f48cbba", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20200430pack3.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("a69dd2e42b776db5", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20200430pack4.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("b271c747d2bb8bb7", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20200430pack5.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("74079871e613c9a2", VcmCurrency.diamond, 192, 108,
                    "com.nintendo.zaga.20200430pack6.tier4", 3.99,
                    3.99, "USD", "", ""),
                new VcmBundleItem("7d5f358ad8b4b3e8", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20200507pack7.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("e8f988da62e52ff6", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20200507pack8.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("a8b20ea697313f5d", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20200730pack1.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("45b446d0bd04a094", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20200730pack2.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("ac119b9253f5519e", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.20200730pack3.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("b049b6047d6c67d8", VcmCurrency.diamond, 3920, 1780,
                    "com.nintendo.zaga.20200730pack4.tier56",
                    79.99, 79.99, "USD", "", ""),
                new VcmBundleItem("da044ec1edb6236c", VcmCurrency.diamond, 3920, 1780,
                    "com.nintendo.zaga.20200927pack1.tier56",
                    79.99, 79.99, "USD", "", ""),
                new VcmBundleItem("317cc937510de998", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20200927pack2.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("7758792c2aeea5d7", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20200927pack3.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("8b73a65549eaeaf5", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20200927pack4.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("295cb6d4089b306f", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.20200927pack5.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("8f6458f49a03b257", VcmCurrency.diamond, 840, 360,
                    "com.nintendo.zaga.20200927pack6.tier17", 16.99,
                    16.99, "USD", "", ""),
                new VcmBundleItem("ecc1912bf67a4f2b", VcmCurrency.diamond, 480, 480,
                    "com.nintendo.zaga.20200927pack7.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("f9761cdb851a515c", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20201231pack1.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("dbc7bfb292ad3148", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20201231pack2.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("d578e683ad81b084", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20201231pack3.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("340cc82a2fc3386c", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20201231pack4.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("eade4a89139c1f4c", VcmCurrency.diamond, 840, 360,
                    "com.nintendo.zaga.20201231pack5.tier17", 16.99,
                    16.99, "USD", "", ""),
                new VcmBundleItem("4c0dcbcbbde0e11b", VcmCurrency.diamond, 3920, 1780,
                    "com.nintendo.zaga.20210131pack1.tier56",
                    79.99, 79.99, "USD", "", ""),
                new VcmBundleItem("90ba9167a0cd4c1c", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20210131pack2.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("4eb428864af342cb", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20210131pack3.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("fabfac9bf7dd7073", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20210131pack4.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("35c0de24a3061eff", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20210131pack5.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("ac8a5f7921c619d8", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20210131pack6.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("89620dca57874084", VcmCurrency.diamond, 840, 360,
                    "com.nintendo.zaga.20210131pack7.tier17", 16.99,
                    16.99, "USD", "", ""),
                new VcmBundleItem("3af18df9d986ecee", VcmCurrency.diamond, 3920, 1780,
                    "com.nintendo.zaga.20210327pack1.tier56",
                    79.99, 79.99, "USD", "", ""),
                new VcmBundleItem("d8249eb41984162d", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20210327pack2.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("16162c15c6d9c1bb", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20210327pack3.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("3f076ddf5aba066e", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20210327pack4.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("32fdd0be8767498d", VcmCurrency.diamond, 840, 360,
                    "com.nintendo.zaga.20210327pack5.tier17", 16.99,
                    16.99, "USD", "", ""),
                new VcmBundleItem("85d2ee6c03bb75ce", VcmCurrency.diamond, 480, 480,
                    "com.nintendo.zaga.20210327pack6.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("6dadb50ce38319e3", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20210327pack7.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("401006daa17f9a99", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20210327pack8.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("f7e2aa34ec90cff4", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.20210730pack2.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("2083f9abba2a599c", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20210730pack3.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("afc662a09d9db8f6", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20210730pack4.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("745ce1706517f4aa", VcmCurrency.diamond, 3920, 1780,
                    "com.nintendo.zaga.20210927pack1.tier56",
                    79.99, 79.99, "USD", "", ""),
                new VcmBundleItem("82f759b645bae5e7", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20210927pack2.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("00cf4e36dcb309fc", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20210927pack3.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("75d4eb2a20f07fe4", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20210927pack4.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("29862f66772b8db6", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.20210927pack5.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("6ee29e44b6241b22", VcmCurrency.diamond, 480, 480,
                    "com.nintendo.zaga.20210927pack6.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("68f35f7a0aa44d1e", VcmCurrency.diamond, 840, 360,
                    "com.nintendo.zaga.20210927pack7.tier17", 16.99,
                    16.99, "USD", "", ""),
                new VcmBundleItem("0567fe56315a1a28", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20211231pack1.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("152d3c135320a888", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20211231pack3.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("de0bf198f7e56717", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20211231pack4.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("3839af453a52baae", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.20211231pack5.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("aa41d4550138d10b", VcmCurrency.diamond, 840, 360,
                    "com.nintendo.zaga.20211231pack6.tier17", 16.99,
                    16.99, "USD", "", ""),
                new VcmBundleItem("1d53b3609ea081bc", VcmCurrency.diamond, 3920, 1780,
                    "com.nintendo.zaga.20211231pack7.tier56",
                    79.99, 79.99, "USD", "", ""),
                new VcmBundleItem("bab4c90d7ea7ce32", VcmCurrency.diamond, 3920, 1780,
                    "com.nintendo.zaga.2021730pack1.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("980d32c74553a3a7", VcmCurrency.diamond, 3920, 1780,
                    "com.nintendo.zaga.20220327pack1.tier56",
                    79.99, 79.99, "USD", "", ""),
                new VcmBundleItem("1eb452e53559f1ce", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20220327pack2.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("39a551af1301e55a", VcmCurrency.diamond, 3920, 880,
                    "com.nintendo.zaga.20220327pack3.tier56", 79.99,
                    79.99, "USD", "", ""),
                new VcmBundleItem("79332848cedfcad4", VcmCurrency.diamond, 1920, 480,
                    "com.nintendo.zaga.20220327pack4.tier40", 39.99,
                    39.99, "USD", "", ""),
                new VcmBundleItem("312f13e164211514", VcmCurrency.diamond, 840, 360,
                    "com.nintendo.zaga.20220327pack5.tier17", 16.99,
                    16.99, "USD", "", ""),
                new VcmBundleItem("1879dc76e369e341", VcmCurrency.diamond, 480, 480,
                    "com.nintendo.zaga.20220327pack6.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("687d5e66f1706be1", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20220327pack7.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("b99f2bc053f9bca5", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20220327pack8.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("00d14304903ead72", VcmCurrency.diamond, 480, 220,
                    "com.nintendo.zaga.20220327pack9.tier10", 9.99,
                    9.99, "USD", "", ""),
                new VcmBundleItem("9e316a8e06d9788a", VcmCurrency.diamond, 1920, 80,
                    "com.nintendo.zaga.amulet.release.tier40", 39.99,
                    39.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("d5334e495de641a8", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.amulet.strength.20190701.pack.tier8", 7.99, 7.99, "USD", ""),
                new VcmBundleItem("d9e58fb126283fd4", VcmCurrency.diamond, 960, 540,
                    "com.nintendo.zaga.chara.mission.tier20", 19.99,
                    19.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("24097eeef7a56bb4", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.chara.traning.20190701.pack.tier8", 7.99, 7.99, "USD", ""),
                new VcmBundleItem("266d8b7ef0cd5943", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.chara.traning.pack.tier8",
                    7.99, 7.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("54a4b9c0a5ab65ff", VcmCurrency.diamond, 960, 540,
                    "com.nintendo.zaga.chara2.mission.tier20", 19.99,
                    19.99, "USD", "", ""),
                new VcmBundleItem("1f8b332543e7df6d", VcmCurrency.diamond, 960, 540,
                    "com.nintendo.zaga.dbattle.mission.tier20",
                    19.99, 19.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("4ad38841c349aa32", VcmCurrency.diamond, 1920, 80,
                    "com.nintendo.zaga.dragon.release.tier40", 39.99,
                    39.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("236e80dcdfa04ba4", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.dragon.strength.20190701.pack.tier8", 7.99, 7.99, "USD", ""),
                new VcmBundleItem("339586983ab2fc73", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.flame.resource.20190701.pack.tier8", 7.99, 7.99, "USD", ""),
                new VcmBundleItem("265881bc232ff9a2", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.flame.resource.pack.tier8",
                    7.99, 7.99, "USD", ""),
                new VcmBundleItem("cd1fddba4150cc3d", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.light.resource.20190701.pack.tier8", 7.99, 7.99, "USD", ""),
                new VcmBundleItem("fdc6c38b2a219f91", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.light.resource.pack.tier8",
                    7.99, 7.99),
                new VcmBundleItem("4c5fd0d72148cfda", VcmCurrency.diamond, 480, 0, "com.nintendo.zaga.login.tier10",
                    9.99, 9.99,
                    "USD", "title mock", "detail mock"),
                new VcmBundleItem("40cbfcce74371877", VcmCurrency.diamond, 1920, 80,
                    "com.nintendo.zaga.manacircle.release.tier40",
                    39.99, 39.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("faf1cf97b959b845", VcmCurrency.diamond, 480, 480, "com.nintendo.zaga.pocket.tier10",
                    9.99, 9.99,
                    "USD", "title mock", "detail mock"),
                new VcmBundleItem("96a6b093371e52a6", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.shadow.resource.20190701.pack.tier8", 7.99, 7.99, "USD", ""),
                new VcmBundleItem("a9bdf8380fac5768", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.shadow.resource.pack.tier8",
                    7.99, 7.99),
                new VcmBundleItem("0f55515e286900fa", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.startdash.tier25", 24.99,
                    24.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("7bb6ec935fab7a92", VcmCurrency.diamond, 1200, 300,
                    "com.nintendo.zaga.startdash2.tier25", 24.99,
                    24.99, "USD", "", ""),
                new VcmBundleItem("d9088c5a016e9729", VcmCurrency.diamond, 384, 1116, "com.nintendo.zaga.starter.tier8",
                    7.99, 7.99,
                    "USD", "title mock", "detail mock"),
                new VcmBundleItem("ba64f7016a061113", VcmCurrency.diamond, 384, 1116,
                    "com.nintendo.zaga.starter2.tier8", 7.99, 7.99, "USD", "", ""),
                new VcmBundleItem("4f79232514717f68", VcmCurrency.diamond, 480, 270,
                    "com.nintendo.zaga.story.mission.h.tier10", 9.99, 9.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("b7822fecd610b1fa", VcmCurrency.diamond, 480, 270,
                    "com.nintendo.zaga.story.mission.n.tier10", 9.99, 9.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("4fae92de7afb23fb", VcmCurrency.diamond, 480, 270,
                    "com.nintendo.zaga.story2.mission.h.tier10", 9.99, 9.99, "USD", "", ""),
                new VcmBundleItem("0378f7e542689d52", VcmCurrency.diamond, 480, 270,
                    "com.nintendo.zaga.story2.mission.n.tier10", 9.99, 9.99, "USD", "", ""),
                new VcmBundleItem("164569fabe59cba1", VcmCurrency.diamond, 48, 0, "com.nintendo.zaga.tier1", 0.99, 0.99,
                    "USD", "title mock", "detail mock"),
                new VcmBundleItem("faf8a156d65f324f", VcmCurrency.diamond, 480, 4, "com.nintendo.zaga.tier10", 9.99,
                    9.99),
                new VcmBundleItem("47eccf138a3aab63", VcmCurrency.diamond, 960, 20, "com.nintendo.zaga.tier20", 19.99,
                    19.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("4f5023dbd61fb884", VcmCurrency.diamond, 1200, 30, "com.nintendo.zaga.tier25", 24.99,
                    24.99, "USD", ""),
                new VcmBundleItem("9a9e9eeb166f9ce9", VcmCurrency.diamond, 144, 1, "com.nintendo.zaga.tier3", 2.99,
                    2.99, "USD", "title mock", "detail mock", false, 0),
                new VcmBundleItem("7768f88574a4e14e", VcmCurrency.diamond, 1520, 40, "com.nintendo.zaga.tier32", 31.99,
                    31.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("96e0b800afa80a6d", VcmCurrency.diamond, 192, 1, "com.nintendo.zaga.tier4", 3.99,
                    3.99),
                new VcmBundleItem("a573092c0fb77907", VcmCurrency.diamond, 1920, 80, "com.nintendo.zaga.tier40", 39.99,
                    39.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("b7560d96b12c8789", VcmCurrency.diamond, 3920, 280, "com.nintendo.zaga.tier56", 79.99,
                    79.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("1aa9384a857eaa0c", VcmCurrency.diamond, 384, 6, "com.nintendo.zaga.tier8", 7.99,
                    7.99, "USD", "title mock", "detail mock", false, 0),
                new VcmBundleItem("0c4605a9d320ec60", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.water.resource.20190701.pack.tier8", 7.99, 7.99, "USD", ""),
                new VcmBundleItem("8799a95eff3c91ae", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.water.resource.pack.tier8", 7.99, 7.99),
                new VcmBundleItem("2e1f7248a857fd6b", VcmCurrency.diamond, 1920, 80,
                    "com.nintendo.zaga.weapon.20201101.release.tier40", 39.99, 39.99, "USD", "", ""),
                new VcmBundleItem("69e097e5e523adee", VcmCurrency.diamond, 960, 540,
                    "com.nintendo.zaga.weapon.mission.tier20", 19.99, 19.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("3993a56d3a009be7", VcmCurrency.diamond, 1920, 80,
                    "com.nintendo.zaga.weapon.release.tier40", 39.99, 39.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("2f292770c60b604f", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.weapon.strength.20190701.pack.tier8", 7.99, 7.99, "USD", ""),
                new VcmBundleItem("324bc8c8859f3654", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.weapon.strength.pack.tier8", 7.99, 7.99, "USD", "title mock", "detail mock"),
                new VcmBundleItem("02fa154efb70ffe2", VcmCurrency.diamond, 960, 540,
                    "com.nintendo.zaga.weapon2.mission.tier20", 19.99, 19.99, "USD", "", ""),
                new VcmBundleItem("d2f25a13b6f2a2ad", VcmCurrency.diamond, 1920, 80,
                    "com.nintendo.zaga.weapon6.release.tier40", 39.99, 39.99, "USD", "", ""),
                new VcmBundleItem("fc81a9ffeca1eba5", VcmCurrency.diamond, 48, 27, "com.nintendo.zaga.weekly.tier1",
                    0.99, 0.99),
                new VcmBundleItem("0f282b8de779a6c6", VcmCurrency.diamond, 96, 54, "com.nintendo.zaga.weekly.tier2",
                    1.99, 1.99),
                new VcmBundleItem("724a9d40a5cb13da", VcmCurrency.diamond, 192, 108, "com.nintendo.zaga.weekly.tier4",
                    3.99, 3.99),
                new VcmBundleItem("5e020aa584054a3a", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.wind.resource.20190701.pack.tier8", 7.99, 7.99, "USD", ""),
                new VcmBundleItem("15660d969611af8a", VcmCurrency.diamond, 384, 16,
                    "com.nintendo.zaga.wind.resource.pack.tier8", 7.99, 7.99)
            ])
        ];
};

public record VcmBundleItem(
    string Id = "",
    VcmCurrency VirtualCurrencyName = VcmCurrency.diamond,
    uint Amount = 0,
    uint ExtraAmount = 0,
    string Sku = "",
    double UsdPrice = 0,
    double Price = 0,
    string PriceCode = "USD",
    string? Title = null,
    string? Detail = null,
    bool Disabled = false,
    uint EventNotifyStartAt = 1,
    object? CustomAttribute = null
);