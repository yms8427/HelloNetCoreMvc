var Package = function (id, name) {
    this.id = id;
    this.name = name;
    this.price = 0;
    this.userCount = 0;
    this.storage = 0;
    this.supportType = "";
}
Package.prototype.setPrice = function (p) {
    this.price = p;
}
Package.prototype.setUserCount = function (uc) {
    this.userCount = uc;
}
Package.prototype.setStorage = function (s) {
    this.storage = s;
}
Package.prototype.setSupportType = function (s) {
    this.supportType = s;
}

var instance = {
    data: function () {
        return {
            packages: []
        }
    },
    mounted: function () {
        var p1 = new Package(1, "Ücretsiz");
        p1.setStorage(10);
        p1.setUserCount(20);
        p1.setSupportType("E-posta hizmeti");
        this.packages.push(p1);

        var p2 = new Package(2, "Profesyonel");
        p2.setPrice(40);
        p2.setStorage(20);
        p2.setUserCount(40);
        p2.setSupportType("E-posta ve arama hizmeti");
        this.packages.push(p2);

        var p3 = new Package(3, "Kurumsal");
        p3.setPrice(80);
        p3.setStorage(40);
        p3.setUserCount(120);
        p3.setSupportType("E-posta, arama ve teknik destek hizmeti");
        this.packages.push(p3);
    }
};
Vue.createApp(instance).mount("#camp");