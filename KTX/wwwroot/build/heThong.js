var vuejs = Vue.createApp({
    data() {
        return {
            avataStyle: {
                backgroundImage: 'url(../img/avatar.jpg)'
            },
            options: {},
            chonDonVi: "", getDanhSachDonVi: [],
            dsMenu: {}, thongTinNSD: {},
            dsDonVi: []
        }
    },
    computed: {
        GetParent: function () {
            var arr = $.grep(this.dsMenu, function (val, index) {
                return val.IdCapTren == ""
            });

            return arr;
        }
    },
    created: function() { 
        this.ThongTinDonVi();
        this.ThongTinNguoiDung();
        this.GenMenuFile();
    }, 
    methods: {
        getTen: function () { 
            return "Xin chào: " + (this.thongTinNSD == null ? "" : this.thongTinNSD.TenDaiDien);
        },
        getCss: function (val) {
            if (val == "0") {
                return "nav-item has-treeview";
            }
            else if (val == "1") {
                return "nav-item has-treeview menu-open";
            }
            else return 'nav-item';
        },
        getCssChidrent: function (val) {
            if (val == "0") {
                return "nav-link";
            }
            else if (val == "2") {
                return "nav-link active";
            }

            else return 'nav-link';
        },
        getRealUrl(urlBase) {
            return isNullOrEmty(urlBase) ? "#" : urlBase;
        },
        LayDanhSachMenuCon: function (ma) {
            var arr = $.grep(this.dsMenu, function (val, index) {
                return val.IdCapTren == ma;
            });
            return arr;
        },
        Check: function (ma) {
            return this.LayDanhSachMenuCon(ma).length > 0 ? true : false;
        },

        ThongTinDonVi: function () {
            $.ajax({
                type: "GET",
                url: heThong.urlThongTinDonVi,
                dataType: "json",
                success: function (b_data) { 
                    vuejs.getDanhSachDonVi = b_data;
                    if (b_data.length > 0) {
                        vuejs.chonDonVi = b_data[0].IdDonVi;
                    }
                }
            });
        },
        
        ThongTinNguoiDung: function () {
            $.ajax({
                type: "GET",
                url: heThong.urlThongTinNguoiDung,
                dataType: "json",
                success: function (b_data) { 
                    vuejs.thongTinNSD = b_data; 
                }
            });
        },

        GenMenuFile: function () {
            var path = window.location.pathname;
            $.ajax({
                type: "GET",
                url: heThong.urlMenu + "?path=" + path,
                dataType: "json",
                success: function (b_data) {
                    vuejs.dsMenu = b_data;
                }
            });
        },
        setFullWidth: function () {
            var e = window.document,
                t = e.documentElement,
                n = t.requestFullscreen,
                a = e.exitFullscreen;
            e.fullscreenElement ? (a.call(e), z(!1)) : (n.call(t), z(!0))
        },



        DangXuatTaiKhoan: function () {
            $.ajax({
                type: "GET",
                url: heThong.urlLogOut,
                success: function (b_data) {
                    window.location.assign(b_data.Url);
                }
            });
        },
        ChonLaiDonVi: function (value) {
            $.ajax({
                type: "GET",
                url: this.urlChonLaiDonVi + "?id=" + value,
                success: function (b_data) {
                    window.location.reload();
                }
            });
        },
        ChonLaiDonVi: function (value) {
            $.ajax({
                type: "GET",
                url: heThong.urlThongTinDonVi,
                success: function (b_data) {

                }
            });
        }

    }
}).mount('#header');;