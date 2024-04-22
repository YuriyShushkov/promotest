const PROXY_CONFIG = [
  {
    context: [
      "/country",
    ],
    target: "https://localhost:7211",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
