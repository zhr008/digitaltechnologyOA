/**
 * Created with JetBrains PhpStorm.
 * User: xuheng
 * Date: 12-9-26
 * Time: ����1:09
 * To change this template use File | Settings | File Templates.
 */
var charsContent = [
    { name:"tsfh", title:lang.tsfh, content:toArray("��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,�@,�A,�B,�C,�D,�E,�F,�G,�H,�I,�J,�K,�L,�M,�N,�O,�P,�Q,�R,�S,�T,�U,�V,�W,�Y,�@,�A,�B,�C,�D,�E,�F,�G,�H,�I,�J,�K,�L,�M,�N,�O,�P,�Q,�R,�S,�T,�U,�V,�W,�X,�Y,�Z,�[,�\,�],�^,�_,�`,�a,�b,�c,�d,�e,�f,�g,�h,�i,�j,�k,�l,�m,�n,�o,�p,�q,�r,�s,�t,�u,�v,�w,�x,�y,�z,�{,�|,�},�~,,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��")},
    { name:"lmsz", title:lang.lmsz, content:toArray("��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��")},
    { name:"szfh", title:lang.szfh, content:toArray("��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��")},
    { name:"rwfh", title:lang.rwfh, content:toArray("��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��")},
    { name:"xlzm", title:lang.xlzm, content:toArray("��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��")},
    { name:"ewzm", title:lang.ewzm, content:toArray("��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��")},
    { name:"pyzm", title:lang.pyzm, content:toArray("��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��")},
    { name:"zyzf", title:lang.zyzf, content:toArray("��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��")}
];
(function createTab(content) {
    for (var i = 0, ci; ci = content[i++];) {
        var span = document.createElement("span");
        span.setAttribute("tabSrc", ci.name);
        span.innerHTML = ci.title;
        if (i == 1)span.className = "focus";
        domUtils.on(span, "click", function () {
            var tmps = $G("tabHeads").children;
            for (var k = 0, sk; sk = tmps[k++];) {
                sk.className = "";
            }
            tmps = $G("tabBodys").children;
            for (var k = 0, sk; sk = tmps[k++];) {
                sk.style.display = "none";
            }
            this.className = "focus";
            $G(this.getAttribute("tabSrc")).style.display = "";
        });
        $G("tabHeads").appendChild(span);
        domUtils.insertAfter(span, document.createTextNode("\n"));
        var div = document.createElement("div");
        div.id = ci.name;
        div.style.display = (i == 1) ? "" : "none";
        var cons = ci.content;
        for (var j = 0, con; con = cons[j++];) {
            var charSpan = document.createElement("span");
            charSpan.innerHTML = con;
            domUtils.on(charSpan, "click", function () {
                editor.execCommand("insertHTML", this.innerHTML);
                dialog.close();
            });
            div.appendChild(charSpan);
        }
        $G("tabBodys").appendChild(div);
    }
})(charsContent);
function toArray(str) {
    return str.split(",");
}
