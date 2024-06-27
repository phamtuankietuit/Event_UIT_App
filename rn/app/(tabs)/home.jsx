import {
  View,
  Text,
  RefreshControl,
  Image,
  Pressable,
  ActivityIndicator,
  ScrollView,
  ToastAndroid,
  FlatList,
  Animated,
  TouchableOpacity,
} from "react-native"
import { useState, useCallback, useEffect } from "react"
import * as EventServices from "../apiServices/eventServices"
import Logo from "../../assets/images/Logo.png"
import Carousel from "../components/Carousel"
import EventItem from "../components/EventItem"

const slides = [
  "https://thanhnien.mediacdn.vn/thumb_w/750/325084952045817856/2023/3/20/base64-16792880739381319994436.jpeg",
  "https://tuyensinh.uit.edu.vn/sites/default/files/uploads/images/202310/2b7173db-6933-4f88-b227-ebf0e042c41e.png",
  "https://www.uit.edu.vn/sites/vi/files/image_from_word/hoc_bong_khoa_khoa_hoc_may_tinh_7.jpg",
  "https://www.uit.edu.vn/sites/vi/files/image_from_word/u.jpg",
]

const Home = () => {
  const [isLoading, setIsLoading] = useState(false)

  const [data, setData] = useState([])
  const [refreshing, setRefreshing] = useState(false)

  const onRefresh = useCallback(() => {
    setRefreshing(true)
    setTimeout(() => {
      setData([
        ...data,
        { key: (data.length + 1).toString(), text: `Item ${data.length + 1}` },
      ])
      setRefreshing(false)
    }, 1500)
  }, [data])

  // TAB
  const [tab, setTab] = useState(1)

  const showToastWithGravity = (msg) => {
    ToastAndroid.showWithGravity(
      msg || "hello",
      ToastAndroid.SHORT,
      ToastAndroid.CENTER
    )
  }

  const handleChangeTab = (tab) => {
    setTab(tab)
    showToastWithGravity("oke")
  }

  const [scrollY, setScrollY] = useState(new Animated.Value(0))

  const animatedTop = scrollY.interpolate({
    inputRange: [0, 500],
    outputRange: [210, 0],
    extrapolate: "clamp",
  })
  useEffect(() => {
    const fetchApi = async () => {
      const responseEvent = await EventServices
        .getEvents({
          isPublished: true
        })
        .catch((error) => {
          // xử lý lỗi
          if (error.response) {
            if (error.response.status === 401) {
              showToastWithGravity("Vui lòng kiểm tra lại email hoặc mật khẩu")
            } else if (error.response.status === 403) {
              showToastWithGravity("Tài khoản đã bị vô hiệu hóa")
            }
          } else {
            showToastWithGravity("Có lỗi xảy ra")
          }
        })

      if (responseEvent) {
        // Xử lý nếu response trả về
        // console.log(responseEvent.events.items)
        setData(responseEvent.events.items)
      }
    }
    fetchApi()
  }, [])
  return (
    <View className='relative flex h-full flex-1 flex-col bg-slate-200'>
      <View
        className={
          "absolute left-0 top-0 h-[270px] w-full rounded-b-3xl bg-blue-600"
        }
      ></View>

      <View className='mx-2 mb-2 mt-5 flex flex-row items-center'>
        <Image className='h-10 w-10 rounded-full' source={Logo} />
        <Text className='ml-3 text-2xl font-semibold text-white'>
          Event UIT
        </Text>
      </View>

      <View
        className='mx-2 my-3 flex flex-row items-center rounded-3xl bg-white 
        p-1 shadow-sm shadow-black'
      >
        <Pressable
          onPress={() => handleChangeTab(0)}
          className={`${tab === 0 && "bg-blue-600"} flex w-1/2 items-center justify-center 
          rounded-3xl p-2`}
        >
          <View>
            <Text
              className={`${tab === 0 && "text-white"} text-sm font-medium`}
            >
              Đang theo dõi
            </Text>
          </View>
        </Pressable>

        <Pressable
          onPress={() => handleChangeTab(1)}
          className={`${tab === 1 && "bg-blue-600"} flex w-1/2 items-center justify-center 
          rounded-3xl p-2`}
        >
          <View>
            <Text
              className={`${tab === 1 && "text-white"} text-sm font-medium`}
            >
              Tất cả
            </Text>
          </View>
        </Pressable>
      </View>

      <View className='relative'>
        <Carousel />

        <Animated.View
          style={{
            top: animatedTop,
          }}
          className={`absolute left-0 w-full`}
        >
          <View className='h-[700px]'>
            {isLoading ? (
              <View className='h-full rounded-t-2xl bg-white px-3 py-2'>
                <ActivityIndicator size='large' color='#0000ff' />
              </View>
            ) : (
              <FlatList
                className='rounded-t-2xl bg-white px-3 py-2 pt-3 shadow shadow-black'
                data={data}
                keyExtractor={(item) => item.id}
                renderItem={({ item }) => <EventItem item={item} />}
                onScroll={Animated.event(
                  [{ nativeEvent: { contentOffset: { y: scrollY } } }],
                  {
                    useNativeDriver: false,
                  }
                )}
                scrollEventThrottle={16}
                showsVerticalScrollIndicator={false}
                refreshControl={
                  <RefreshControl
                    refreshing={refreshing}
                    onRefresh={onRefresh}
                    colors={["#3A57E8"]}
                    tintColor='#3A57E8'
                    progressViewOffset={20}
                  />
                }
                ListFooterComponent={<View className='mb-52'></View>}
              />
            )}
          </View>
        </Animated.View>
      </View>
    </View>
  )
}

export default Home
