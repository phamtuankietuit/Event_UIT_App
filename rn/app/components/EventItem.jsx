import {
  Text,
  View,
  TouchableOpacity,
  Image,
  ActivityIndicator,
  Pressable,
  Alert,
  ToastAndroid,
  Linking,
} from "react-native"
import React, { memo, useEffect, useState } from "react"
import { SliderBox } from "react-native-image-slider-box"
import { Entypo, AntDesign } from "@expo/vector-icons"
import { Link } from "expo-router"
import dayjs from "dayjs"
import * as asyncStorage from "../store/asyncStorage"
import * as eventServices from "../apiServices/eventServices"

const showToastWithGravity = (msg) => {
  ToastAndroid.showWithGravity(msg, ToastAndroid.SHORT, ToastAndroid.CENTER)
}

const EventItem = memo(({ item, universityUnit }) => {
  const [slides, setSlides] = useState([])
  const [status, setStatus] = useState(null)
  const [showRegister, setShowRegister] = useState(item.isThisStudentRegistered)
  const [buttonLoading, setButtonLoading] = useState(false)

  const handleRegister = async () => {
    // setShowRegister(true)
    setButtonLoading(true)
    const studentId = await asyncStorage.getIdAsync()

    const response = await eventServices
      .registerEvent(item?.id, { EventId: item?.id, StudentId: studentId })
      .catch((error) => {
        if (error.response.status === 409) {
          showToastWithGravity("Sự kiện đã kết thúc")
        }
        console.log("registerEvent", error.response.data)
        setButtonLoading(false)
      })

    if (response) {
      console.log(response)
      setButtonLoading(false)
      setShowRegister(true)
    }
  }

  const confirmRegister = () =>
    Alert.alert(
      "Xác nhận đăng ký",
      "Bạn có chắc chắn đăng ký sự kiện này? Bạn sẽ không thể hủy đăng ký sau đó.",
      [
        {
          text: "Hủy",
          style: "cancel",
        },
        { text: "OK", onPress: () => handleRegister() },
      ]
    )

  useEffect(() => {
    setSlides(item.images.map((image) => image.imageUrl))
    // if (dayjs() >= dayjs(item.startDate) && dayjs() <= dayjs(item.endDate)) {
    //   setStatus(1)
    // } else if (dayjs() < dayjs(item.startDate)) {
    //   setStatus(0)
    // } else {
    //   setStatus(2)
    // }
  }, [])

  return (
    <View
      className='mb-2 max-h-fit w-full rounded border-[1px] 
        border-gray-100 bg-white p-3 shadow-sm shadow-gray-600'
    >
      <Link
        href={{
          pathname: "(page)/page-detail/[id]",
          params: {
            id: universityUnit ? universityUnit.id : item.universityUnit.id,
          },
        }}
      >
        <View className='flex-row items-center justify-between'>
          <View className='flex-row items-center justify-center'>
            <View className='h-10 w-10 rounded-full border-[1px] border-gray-400'>
              <Image
                className='h-full w-full rounded-full'
                source={{
                  uri: universityUnit
                    ? universityUnit.avatarUrl
                    : item.universityUnit.avatarUrl,
                }}
              ></Image>
            </View>

            <View className='ml-2 w-[180px]'>
              <Text
                numberOfLines={1}
                ellipsizeMode='tail'
                lineBreakMode='tail'
                className='text-base font-semibold'
              >
                {universityUnit
                  ? universityUnit.name
                  : item.universityUnit.name}
              </Text>
              <Text className='text-xs'>
                {dayjs(item.publishedDate).format("HH:mm - DD/MM/YYYY")}
              </Text>
            </View>
          </View>

          {
            <View className=''>
              <Text
                className={`
                  ${dayjs() < dayjs(item.startDate) && "text-orange-500"}
                  ${dayjs() >= dayjs(item.startDate) && dayjs() <= dayjs(item.endDate) && "text-green-500"}
                  ${dayjs() > dayjs(item.endDate) && "text-red-500"} 
                  ext-sm font-medium `}
              >
                {dayjs() < dayjs(item.startDate) && "Chưa bắt đầu"}
                {dayjs() >= dayjs(item.startDate) &&
                  dayjs() <= dayjs(item.endDate) &&
                  "Đang diễn ra"}
                {dayjs() > dayjs(item.endDate) && "Kết thúc"}
              </Text>
              <Text className='text-xs'>
                {item.totalRegistration}/{item.maxAttendees}
              </Text>
            </View>
          }
        </View>
      </Link>

      <View className='mt-2'>
        <Text
          className='text-base font-medium'
          numberOfLines={2}
          ellipsizeMode='tail'
        >
          {item.title}
        </Text>
        <Text numberOfLines={5} ellipsizeMode='tail'>
          {item.description}
        </Text>
        <Link
          href={{
            pathname: "/(page)/post-detail/[id]",
            params: { id: item.id },
          }}
        >
          <Text className='text-blue-500'>Xem thêm</Text>
        </Link>
      </View>

      <View className='mt-2 max-h-[200px] items-center justify-center'>
        <SliderBox
          images={slides}
          dotColor='#FFFFFF'
          inactiveDotColor='#F5F5F5'
          ImageComponentStyle={{ borderRadius: 5, width: "80%" }}
          imageLoadingColor='#3A57E8'
        />
      </View>

      <View className='my-3 h-[0.5px] w-full bg-gray-300'></View>

      <View className='flex-row justify-between'>
        <TouchableOpacity
          className='items-center justify-center rounded bg-blue-500 px-3'
          onPress={() => Linking.openURL(item.universityUnit.facebookUrl)}
        >
          <AntDesign name='facebook-square' size={20} color='white' />
        </TouchableOpacity>

        {/* bg-slate-400 */}

        {showRegister ? (
          <View className='rounded bg-slate-500 px-5 py-2'>
            <Text className='font-medium text-white'>Đã đăng ký</Text>
          </View>
        ) : (
          <TouchableOpacity
            className='rounded bg-blue-500 px-5 py-2'
            onPress={confirmRegister}
            disabled={buttonLoading}
          >
            {buttonLoading ? (
              <ActivityIndicator size='small' color='#ffffff' />
            ) : (
              <Text className='font-medium text-white'>Đăng ký</Text>
            )}
          </TouchableOpacity>
        )}
      </View>
    </View>
  )
})

export default EventItem
