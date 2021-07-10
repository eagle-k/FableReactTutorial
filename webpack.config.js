const path = require("path");

const HtmlWebpackPlugin = require("html-webpack-plugin");

module.exports = {
    mode: "development",
    entry: ["./src/Program.fs.js", "./src/index.css"],
    output: {
        path: path.resolve(__dirname, "./public"),
        filename: "[name].js",
        clean: true,
    },
    plugins: [
        new HtmlWebpackPlugin({
            filename: "index.html",
            template: "./src/index.html",
        }),
    ],
    resolve: {
        symlinks: false,
    },
    module: {
        rules: [
            {
                test: /\.css$/i,
                use: ["style-loader", "css-loader"],
            },
        ],
    },
    devtool: "eval-source-map",
    optimization: {
        splitChunks: {
            chunks: "all",
        },
    },
    devServer: {
        contentBase: false,
        port: 8080,
    },
};
